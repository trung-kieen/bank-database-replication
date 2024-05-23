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
    public partial class formTaoLogin : DevExpress.XtraEditors.XtraForm
    {
        public formTaoLogin()
        {
            InitializeComponent();

        }

        private void thongKeKH_Load(object sender, EventArgs e)
        {
            LoadCmbChiNhanh();
            CenterMdiScreen();
            SetDefaultInputValue();
            LoadListAccounts();

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
                LoadListAccounts();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport thongKeKhachHang;
            try
            {
                String QueryAllSite = "SP_ThongKeKhachHang_SongSong";
                // Require to run SP from remote server with serverrole sysadmin to able update and delete job agent
                thongKeKhachHang = new rptKhachHang(Connstr: Program.GetConnString(
                    Program.remotelogin, Program.remotepassword, Program.servername),
                    SP_Name: QueryAllSite);
                thongKeKhachHang = new rptKhachHang(Program.connstr);
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
        }
        private void LoadListAccounts()
        {
            if (!radioNhanVien.Checked && !radioKhachHang.Checked)
            {
                radioKhachHang.Checked = true;
                // Avoid recursive
                return;
            }
            String cmd = radioNhanVien.Checked ? "SELECT * FROM uv_DanhSachNhanVien" : "SELECT * FROM uv_DanhSachKhachHang";
                if (Program.KetNoi() == Database.Connection.Fail) return;
                try {
                DataTable dsnv = Program.ExecSqlDataTable(cmd);
                tkCmb.DataSource = dsnv;
                tkCmb.DisplayMember = "DisplayMember";
                tkCmb.ValueMember = "ValueMember"; // Which is user name 
                }
                catch
                {
                    Msg.Error("Không thể tải được danh sách đối tượng để tạo tài khoản đăng nhập");
                    return;
                }

        }
        private void LoadLogin()
        {
            try
            {
                txtUserName.Text = tkCmb.SelectedValue.ToString();
                txtUserName.Enabled = false;
            }
            catch
            {
                Msg.Error("Không thể tải mã người dùng");
            }
        }

        private void radio_SelectedChange(object sender, EventArgs e)
        {
            LoadListAccounts();
        }

        private void tkCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tkCmb.SelectedValue.ToString() == "System.Data.DataRowView") return;
            LoadLogin();
        }
    }
}