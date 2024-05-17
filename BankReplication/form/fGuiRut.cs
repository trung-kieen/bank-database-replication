using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BankReplication.utils;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
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
            txtSoDu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtSoDu.Properties.Mask.EditMask = "n0";
            txtSoDu.Properties.Mask.UseMaskAsDisplayFormat = true;

            txtSoTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtSoTien.Properties.Mask.EditMask = "n0";
            txtSoTien.Properties.Mask.UseMaskAsDisplayFormat = true;
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
            }
            txtSoDu.Enabled = false;
            txtSoDu.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(txtSoDu.Text));
            // TODO: This line of code loads data into the 'accountDetails.uv_AccountDetails' table. You can move, or remove it, as needed.
            //            this.uv_AccountDetailsTableAdapter.Fill(this.accountDetails.uv_AccountDetails);

        }

        private void btnGuiRut_Click(object sender, EventArgs e)
        {
            // Validate input 

            try
            {
                if (txtSoTien.Text.ToString() == "")
                    throw new Exception("Số tiền không được để trống");
                if (Double.Parse(txtSoTien.Text) < 0)
                    throw new Exception("Số tiền không thể là số âm");

            }
            catch (Exception ex)
            {
                txtSoTien.Focus();
                Msg.Warm("Số tiền không hợp lệ\n" + ex.Message);
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
                    Msg.Info("Giao dịch thành công \nSố dư mới là " + sodu_moi);
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