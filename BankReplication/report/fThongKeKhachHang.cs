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

namespace BankReplication.report
{
    public partial class formThongKeKH : DevExpress.XtraEditors.XtraForm
    {
        public formThongKeKH()
        {
            InitializeComponent();

        }

        private void formThongKeGD_Load(object sender, EventArgs e)
        {
            LoadAccountDetails(Program.connstr);
            LoadCmbChiNhanh();
            CenterMdiScreen();
            SetDefaultInputValue();

            if (Program.mGroup.ToUpper() == "NGANHANG")
                controlAllSiteCheck.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                controlAllSiteCheck.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
        private void SetDefaultInputValue()
        {
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

        private void LoadAccountDetails(String connstr)
        {
            
            uv_AccountDetailsTableAdapter.Connection.ConnectionString = connstr;
            // TODO: This line of code loads data into the 'accountDetails.uv_AccountDetails' table. You can move, or remove it, as needed.
            this.uv_AccountDetailsTableAdapter.Fill(this.accountDetails.uv_AccountDetails);
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
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //                String sotk = tkCmb.Text.ToString();
                //                String searchExpression = "SOTK = " + sotk;
                //                DataRow matchAccount = accountDetails.Tables["uv_AccountDetails"].Select(searchExpression)[0];
                //                String hoten = matchAccount["HOTEN"].ToString();
                // NOTE: grant permission for NGANHANG, Chi Nhanh to perform this action 
                XtraReport thongKeTaiKhoan = new rptKhachHang();


                IReportPrintTool print = new ReportPrintTool(thongKeTaiKhoan);
                print.ShowPreviewDialog();
            }
            catch(Exception ex)
            {
                Msg.Error("Không thể tải báo cáo\n" +  ex.Message);

            }

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkAllSite_CheckedChanged(object sender, EventArgs e)
        {
            cmbChiNhanh.Enabled = !checkAllSite.Checked;
        }
    }
}