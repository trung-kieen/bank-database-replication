using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using static BankReplication.utils.Validate;
using BankReplication.utils;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
// Author: trung-kieen

/*
 * Form perform action when employee a transfer money for user
 */
namespace BankReplication.form
{
    public partial class formChuyenTien : SimpleForm
    {
        public formChuyenTien()
        {
            InitializeComponent();
        }

        private void CenterMdiScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
            // Make form content center of parrent mdi
            panelContainer.Location = new Point(
                this.ClientSize.Width / 2 - panelContainer.Size.Width / 2,
                this.ClientSize.Height / 2 - panelContainer.Size.Height / 2);
            panelContainer.Anchor = AnchorStyles.None;
        }
        private void fChuyenTienLoad(object sender, EventArgs e)
        {
            formatDisplayAsMoney(txtSoDu);
            formatDisplayAsMoney(txtSoTien);
            CenterMdiScreen();


            uv_AccountDetailsTableAdapter.Connection.ConnectionString = Program.connstr;
            if (Program.KetNoi() == Database.Connection.Fail) return;

            DataTable dstk_nguon = Program.ExecSqlDataTable("SELECT * FROM uv_SoDuTaiKhoan");

            if (dstk_nguon != null)
            {
                tkNguonCmb.DataSource = dstk_nguon;
                tkNguonCmb.DisplayMember = "SOTK";
                tkNguonCmb.ValueMember = "SODU";
                tkNguonCmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tkNguonCmb.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtSoDu.DataBindings.Add(new System.Windows.Forms.Binding("Text", dstk_nguon, "SODU", true));
                txtHoTenChuyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", dstk_nguon, "HOTEN", true));
            }
            txtSoDu.Enabled = false;
            txtSoDu.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(txtSoDu.Text));

            DataTable dstk_nhan = (dstk_nguon).Clone();

            for (int i = 0; i < dstk_nguon.Rows.Count; i++)
            {
                // Lay danh sach phan manh khac chi nhanh hien tai 
                if (i != Program.mChiNhanh)
                {
                    dstk_nhan.ImportRow(dstk_nguon.Rows[i]);
                }
            }

            if (dstk_nhan != null)
            {

                tkNhanCmb.DataSource = dstk_nhan;
                tkNhanCmb.DisplayMember = "SOTK";
                tkNhanCmb.ValueMember = "SODU";
                tkNhanCmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tkNhanCmb.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtHoTenNhan.DataBindings.Add(new System.Windows.Forms.Binding("Text", dstk_nhan, "HOTEN", true));
            }
        }

        private void  formatDisplayAsMoney(TextEdit field)
        {
            field.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            field.Properties.Mask.EditMask = "n0";
            field.Properties.Mask.UseMaskAsDisplayFormat = true;
        }
        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            // Validate input 

            String sotk_nguon = tkNguonCmb.Text.ToString().Trim();
            String sotk_nhan = tkNhanCmb.Text.ToString().Trim();

            if (InvalidCash(txtSoTien)) return;
            try
            {
                if (Double.Parse(txtSoTien.Text) > Double.Parse(txtSoDu.Text))
                {
                    txtSoTien.Focus();
                    throw new Exception("Số tiền trong tài khoản không đủ để thực hiện giao dịch");
                }

                if (sotk_nguon == sotk_nhan)
                {
                    tkNguonCmb.Focus();
                    throw new Exception("Tài khoản nguồn và tải khoản nhận không được trùng nhau");
                }

            }
            catch (Exception ex)
            {
                Msg.Warm(ex.Message, "Giao dịch không hợp lệ");
                return;

            }

            String confirmMessage = "Số tiền: " + txtSoTien.Text + "\n" + 
                "Bằng chữ: " + MoneyRepersent.So_chu(Double.Parse(txtSoTien.Text));
            if (Msg.InforConfirm(confirmMessage, "Xác nhận giao dịch") != DialogResult.OK)
            {
                return; 
            }


            try
            {
                if (Program.KetNoi() == Database.Connection.Fail) return;

                String manv = Program.username;
                String cmd = $"EXEC SP_ChuyenTien '{sotk_nguon}', '{sotk_nhan}', '{txtSoTien.Text}', '{manv}' ";
                int rtnCode = Program.ExecSqlNonQuery(cmd);
                String sodu_moi = Program.ExecSqlScalar($"SELECT SODU FROM NGANHANG.dbo.TaiKhoan WHERE SOTK = '{sotk_nguon}'");
                txtSoDu.Text = sodu_moi;
                txtSoTien.Text = "";
                if (rtnCode == Database.SqlException.ViolateConstraint) Msg.Error("Số dư tài khoản không đủ để thực hiện giao dịch", "Giao dịch không thành công");
                if (rtnCode != 0) return;
                Msg.Info("Giao dịch thành công \nSố dư mới là "  +  Double.Parse(sodu_moi).ToString("n0"));
            }
            catch (Exception ex)
            {
                Msg.Info("Lỗi thực thi giao dịch\n" + ex.Message);
                return;
            }
        }

        private void txtSoTien_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnChuyenTien.PerformClick();
            }

        }

    }
}