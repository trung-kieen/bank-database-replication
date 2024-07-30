using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DevExpress.XtraReports.UI;
using System.Text;
using BankReplication.utils;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
// Author: trung-kieen

/*
 * Form perform to get user input to provide report from rptGiaoDich.cs
 */
namespace BankReplication.report
{
    public partial class formThongKeGD : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dstk;
        public formThongKeGD()
        {
            InitializeComponent();

        }

        private void formThongKeGD_Load(object sender, EventArgs e)
        {
            LoadAccountDetails(Program.connstr);
            LoadCmbChiNhanh();
            CenterMdiScreen();
            SetDefaultInputValue();
        }
        private void SetDefaultInputValue()
        {
            tungayDateEdit.EditValue = DateTime.Now.AddYears(-1);
            denngayDateEdit.EditValue = DateTime.Now;
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

        private void LoadCustomerDetails()
        {

            if (Program.KetNoi() == Database.Connection.Fail) return;
            try
            {
                String tk = tkCmb.Text.ToString();
                txtChuTK.Text = "";
                txtCMND.Text = "";
                Program.myReader = Program.ExecSqlDataReader("EXEC SP_ThongTinTaiKhoan  '" + tk + "'");
                while (Program.myReader.Read())
                {
                    txtChuTK.Text = Program.myReader["HOTEN"].ToString();
                    txtCMND.Text = Program.myReader["CMND"].ToString();
                }
                Program.myReader.Close();
            }
            catch
            {
                Msg.Warm("Không tìm thấy tài khoản");
            }

        }
        private void LoadAccountDetails(String connstr)
        {

            if (Program.KetNoi() == Database.Connection.Fail) return;
            try
            {
                String cmd = "EXEC SP_DSTaiKhoan_ThongKeGD ";
                if (Program.mGroup == "KhachHang")
                    // Add query for account own by customer persional id 
                    cmd += "'" +  Program.username + "'";

                dstk = Program.ExecSqlDataTable(cmd);
                tkCmb.DataSource = dstk;
                tkCmb.DisplayMember = "SOTK";
                tkCmb.ValueMember = "SOTK";
                tkCmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tkCmb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                Msg.Error("Lỗi tải dữ liệu\n" + ex.Message);
                this.Close();
            }
        }

        private void LoadCmbChiNhanh()
        {
            this.cmbChiNhanh.DataSource = Program.bds_dspm;
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            this.cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup.ToUpper() == "NGANHANG")
            {
                // Make chi nhanh non editable
                // Can change server to load data 
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }

        }
        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                // Get data with remote login HTKN
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == Database.Connection.Fail)
            {
                Msg.Error("Lỗi kết nối về chi nhánh mới");
            }
            else
            {
                // Load data
                LoadAccountDetails(Program.connstr);
                LoadCustomerDetails();
            }

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {

                String sotk = tkCmb.Text.ToString();
                DataRow[] foundAccounts = dstk.Select("SOTK='" + sotk + "'");
                if (foundAccounts.Length ==0)
                {
                    throw new Exception("Bạn không có quyền xem thông tin thống kế giao dịch của tài khoản này");
                }

                String hoten = "";
                Program.myReader = Program.ExecSqlDataReader("EXEC SP_ThongTinTaiKhoan  '" + sotk + "'");
                while (Program.myReader.Read())
                {
                    hoten = Program.myReader["HOTEN"].ToString();
                }
                Program.myReader.Close();
                // NOTE: grant permission for NGANHANG, Chi Nhanh to perform this action 
                XtraReport thongKeTaiKhoan = new rptGiaoDich(sotk, tungayDateEdit.DateTime, denngayDateEdit.DateTime, hoten);
                IReportPrintTool print = new ReportPrintTool(thongKeTaiKhoan);
                print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Msg.Error("Không thể tải báo cáo\n" + ex.Message);

            }

        }

        private void tkCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomerDetails();
        }

        private void tkCmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadCustomerDetails();
            }
        }
    }
}