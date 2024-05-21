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
    public partial class formThongKeTK : DevExpress.XtraEditors.XtraForm
    {
        public formThongKeTK()
        {
            InitializeComponent();

        }

        private void thongKeTK_Load(object sender, EventArgs e)
        {
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
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                    XtraReport thongKeKhachHang = new rptTaiKhoan(tungayDateEdit.DateTime , denngayDateEdit.DateTime, checkAllSite.Checked);
                    IReportPrintTool print = new ReportPrintTool(thongKeKhachHang);
                    print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Msg.Error("Không thể tải báo cáo\n" + ex.Message);

            }

        }


        private void checkAllSite_CheckedChanged(object sender, EventArgs e)
        {
            cmbChiNhanh.Enabled = !checkAllSite.Checked;
        }
    }
}