using System;
using static BankReplication.utils.Validate;
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
            LoadListAccounts();
            LoadTargetRoleCmb();
            LoadLoginAndRole();
        }
        private void LoadTargetRoleCmb()
        {
            roleCmb.DataSource = KeyValue.roles;
            roleCmb.DisplayMember = "Text";
            roleCmb.ValueMember = "Value";

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

        private void btnTaoLogin_Click(object sender, EventArgs e)
        {
            HandleAddLogin();
        }

        private void HandleDeleteLogin()
        {
            if (Program.KetNoi() == Database.Connection.Fail) return;
            try
            {
                var role = roleCmb.SelectedValue;
                String roleString = role == null ? "" : role.ToString();
                String cmd = $"EXEC SP_XoaLogin " + txtLoginName.Text + ", "
                     + txtUserName.Text;
                int IntReturn = Program.ExecSqlNonQuery(cmd);
                if (IntReturn == 0)
                    Msg.Info("Tài khoản được xóa thành công");
            }
            catch
            {
            }
            LoadLoginAndRole();
            
        }
        private void HandleAddLogin()
        {
            if (InvalidLoginAccount()) return;

            if (Program.KetNoi() == Database.Connection.Fail) return;
            try
            {
                var role = roleCmb.SelectedValue;
                String roleString = role == null ? "" : role.ToString();
                String cmd = $"EXEC SP_TaoLogin @login_name= '" + txtLoginName.Text.Trim() + "' "
                + $", @pass= '" + txtPassword.Text + "'"
                + $", @username= '" + txtUserName.Text.Trim() + "'"
                + $", @role= '" + roleString + "'";

                int IntReturn = Program.ExecSqlNonQuery(cmd);
                if (IntReturn == 0)
                    Msg.Info("Tạo tài khoản thành công");
            }
            catch
            {
            }
            LoadLoginAndRole();
        }

        private void LoadListAccounts()
        {
            if(Program.mGroup== "NganHang")
            {
                radioKhachHang.Enabled = false;
                radioNhanVien.Checked = true;
            }
            if (!radioNhanVien.Checked && !radioKhachHang.Checked)
            {
                radioKhachHang.Checked = true;
                // Avoid recursive
                return;
            }
            String cmd = radioNhanVien.Checked ? "SELECT * FROM uv_DanhSachNhanVien" : "SELECT * FROM uv_DanhSachKhachHang";
            if (Program.KetNoi() == Database.Connection.Fail) return;
            try
            {
                DataTable dsnv = Program.ExecSqlDataTable(cmd);
                tkCmb.DataSource = dsnv;
                tkCmb.DisplayMember = "DisplayMember";
                tkCmb.ValueMember = "ValueMember"; // Which is user name 
                tkCmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tkCmb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch
            {
                Msg.Error("Không thể tải được danh sách đối tượng để tạo tài khoản đăng nhập");
                return;
            }

        }
        private void LoadLoginAndRole()
        {
            try
            {
                txtUserName.Text = tkCmb.SelectedValue.ToString();
                txtUserName.Enabled = false;
                Program.myReader = Program.ExecSqlDataReader("EXEC SP_LayThongTinLogin '" + txtUserName.Text + "'");

                lbTaiKhoan.Text = radioKhachHang.Checked ? "Khách hàng" : "Nhân viên";

                // TH da co tai khoan duoc dang ky
                if (Program.myReader.HasRows)
                {
                    Program.myReader.Read();
                    txtLoginName.Text = Program.myReader["TENLOGIN"].ToString();
                    txtLoginName.Enabled = false;
                    txtPassword.Text = "";
                    roleCmb.Enabled = false;
                    roleCmb.SelectedValue = Program.myReader["TENNHOM"].ToString();

                    controlBtnLogin.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    // Chi cho ngan hang va chi nhanh thay doi mat khau, xoa mat khau cho tai khoan cung nhom quyen
                    if (roleCmb.SelectedValue.ToString() == Program.mGroup || roleCmb.SelectedValue.ToString() == "KhachHang")
                    {

                        controlBtnChangePassword.Visibility = controlBtnDelete.Visibility
                            = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        txtPassword.Enabled = true;
                    }
                    else
                    {
                        controlBtnChangePassword.Visibility = controlBtnDelete.Visibility
                            = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        txtPassword.Enabled = false;
                    }

                }
                // Cho phep tao login cho nhan vien hoac khach hang
                else
                {
                    txtLoginName.Text = "";
                    txtPassword.Text = "";
                    txtPassword.Enabled = true;

                    txtLoginName.Enabled = true;
                    roleCmb.Enabled = false;
                    controlBtnLogin.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    controlBtnChangePassword.Visibility = controlBtnDelete.Visibility
                        = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                    if (radioKhachHang.Checked)
                    {
                        roleCmb.SelectedValue = "KhachHang";
                    }
                    else
                    {
                        /* Logic hien tai cho nhanh vien thuoc chi nhanh chi duoc tao login quyen ChiNhanh
                        Nhan vien thuoc ngan hang chi duoc tao login quyen NganHang
                        */
                        roleCmb.SelectedValue = Program.mGroup;
                    }
                }

                if (radioKhachHang.Checked)
                {
                    roleCmb.SelectedIndex = RoleIndex.KhachHang;
                }

            }
            catch
            {
                Msg.Error("Không thể tải mã người dùng");
            }
            Program.myReader.Close();
        }

        private void radio_SelectedChange(object sender, EventArgs e)
        {
            LoadListAccounts();
        }

        private void tkCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tkCmb.SelectedValue.ToString() == "System.Data.DataRowView") return;
            LoadLoginAndRole();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            HandleChangePassword();
        }


        private Boolean InvalidLoginAccount()
        {
            if (InvalidField(txtLoginName, "Tên đăng nhập", validateLoginName)) return true;
            if (InvalidField(txtPassword, "Mật khẩu", validatePassword)) return true;
            return false;
        }

        private void HandleChangePassword()
        {
            if (InvalidLoginAccount()) return;

            if (Program.KetNoi() == Database.Connection.Fail) return;

            String cmd = $"EXEC NGANHANG.dbo.sp_password @old=NULL, @new= '{txtPassword.Text}', @loginame=  '{txtLoginName.Text}'";
                int rtnCode = Program.ExecSqlNonQuery(cmd);
                if (rtnCode == Database.SqlException.ViolateConstraint) Msg.Error("Đổi mật khẩu không thành công");
                if (rtnCode != 0) return;
                Msg.Info("Mật khẩu mới đã được cập nhật thành công");
            }

        private void btnDeleteLogin_Click(object sender, EventArgs e)
        {
            HandleDeleteLogin();
        }
    }
}