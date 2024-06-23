using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BankReplication.utils;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using static BankReplication.utils.Validate;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BankReplication.form
{
    public partial class formGuiRut : SimpleForm
    {
        public formGuiRut()
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
        private void fGuiRut_Load(object sender, EventArgs e)
        {
            CenterMdiScreen();


            loaiGDCmb.Items.AddRange(new object[] {
            new KeyValue("Gửi tiền", "GT"),
            new KeyValue("Rút tiền", "RT")
            });
            this.loaiGDCmb.DisplayMember = "Text";
            this.loaiGDCmb.ValueMember = "Value";
            loaiGDCmb.SelectedIndex = 0;
            uv_AccountDetailsTableAdapter.Connection.ConnectionString = Program.connstr;
            if (Program.KetNoi() == Database.Connection.Fail) return;

            // TODO: Query only this branch 
            DataTable dstk = Program.ExecSqlDataTable("SELECT * FROM uv_SoDuTaiKhoan");

            if (dstk != null)
            {
                tkCmb.DataSource = dstk;
                tkCmb.DisplayMember = "SOTK";
                tkCmb.ValueMember = "SODU";
                tkCmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tkCmb.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtSoDu.DataBindings.Add(new System.Windows.Forms.Binding("Text", dstk, "SODU", true));
                txtChuSoHuu.DataBindings.Add(new System.Windows.Forms.Binding("Text", dstk, "HOTEN", true));
            }
            txtSoDu.Enabled = false;
            txtSoDu.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(txtSoDu.Text));
        }

        private void btnGuiRut_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(txtSoTien.Text) > Double.Parse(txtSoDu.Text) && ((KeyValue)loaiGDCmb.SelectedItem).Value == "RT" )
                {
                    txtSoTien.Focus();
                    throw new Exception("Số tiền trong tài khoản không đủ để thực hiện giao dịch");
                }
            }
            catch (Exception ex)
            {
                Msg.Warm(ex.Message, "Giao dịch không hợp lệ");
                return;
            }
            if (InvalidCash(txtSoTien)) return;
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
                String sotk = tkCmb.Text.ToString();
                KeyValue loaigd = (KeyValue)loaiGDCmb.SelectedItem;
                String cmd = $"EXEC SP_GuiRut '{sotk}', '{txtSoTien.Text}', '{loaigd.Value}', '{manv}' ";
                int rtnCode = Program.ExecSqlNonQuery(cmd);
                String sodu_moi = Program.ExecSqlScalar($"SELECT SODU FROM NGANHANG.dbo.TaiKhoan WHERE SOTK = '{sotk}'");
                txtSoDu.Text = sodu_moi;
                txtSoTien.Text = "";
                if (rtnCode == Database.SqlException.ViolateConstraint) Msg.Error("Hạn mức tối thiểu của giao dịch gửi rút là 100,000 VND", "Giao dịch không thành công");
                if (rtnCode != 0) return;
                Msg.Info("Giao dịch thành công \nSố dư mới là "  +  Double.Parse(sodu_moi).ToString("n0"));
            }
            catch (Exception ex)
            {
                Msg.Info("Lỗi thực thi giao dịch\n" + ex.Message);
                return;
            }
        }

        private void txtSoTien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuiRut.PerformClick();
            }

        }
    }
}