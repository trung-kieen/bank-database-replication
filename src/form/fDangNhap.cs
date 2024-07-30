using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BankReplication.utils;
// Author: trung-kieen


/* 
 * Application have a pulisher connection to connect and query for mapping of bracnches 
 * Each branch have a instance to sql server we gane servername from mapping before
 * Use login via username and password to connect to specific sql server instance
 * Authentication with base on sql server authetication login and password not base on table on a databse 
 * Application will regconize which priviledge of user base on user name
 * Base on role we grant user to access specific form and action on form
 * After user login program will save some information about login 
 * into Program.cs like username, servername, password, login,  ...
 */
namespace BankReplication.form
{
    public partial class formDangNhap : DevExpress.XtraEditors.XtraForm
    {



        // Connection for this login form only for query mapping of branches and 
        private SqlConnection conn_publisher = new SqlConnection();


        /// <summary>
        /// Build pulisher connection string this a hidden connection that allow full access to database 
        /// and full of permission to know how many branches instance and servername for connect 
        /// to their sql server base on servername
        /// </summary>
        /// <returns></returns>
        public int KetNoiCSDLGoc()
        {
            // Close old connection avoid system close connection time out 
            if (conn_publisher != null && conn_publisher.State == System.Data.ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                // Success
                return Database.Connection.Success;
            }
            catch (SqlException e)
            {
                Msg.Error("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n" + e.Message + "\n" + e.State);
                // Error
                return Database.Connection.Fail;
            }
        }


        /// <summary>
        /// Execute query in hidden publisher connection base on command to gain mapping 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        private int LayDSPM(String cmd)
        {
            DataTable dataTable = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
            {
                conn_publisher.Open();
            }

            try
            {

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conn_publisher);


                // Fill mapping to a datatable for display in combobox 
                dataAdapter.Fill(dataTable);
                Program.bds_dspm.DataSource = dataTable;
                cmbChiNhanh.DataSource = dataTable;
                cmbChiNhanh.DisplayMember = "TENCN";
                cmbChiNhanh.ValueMember = "TENSERVER";
                conn_publisher.Close();
                return 1;
            }
            catch (Exception e)
            {
                // Kiểm tra bảng ảo uv_GetSubscribers trong cơ sở dữ liệu
                Msg.Error("Lỗi lấy danh sách các chi nhánh" + e.Message);
                conn_publisher.Close();
                return 0;
            }
        }
        public formDangNhap()
        {
            InitializeComponent();
            CustomLoad();
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        // Lay danh sach cac phan manh len combo box 
        {

            LoadChiNhanh();

        }

        private void LoadChiNhanh()
        {
            if (KetNoiCSDLGoc() == 0) return;
            if (LayDSPM("SELECT * FROM uv_GetSubcribers") == 1)
            {
                cmbChiNhanh.SelectedIndex = 1;
                cmbChiNhanh.SelectedIndex = 0;
            }

        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Class global form => end program
            MdiParent.Close();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Use to future build connection string base on user login and password 
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch
            {
                Msg.Error("Lỗi thiết lập tên server");
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            HandleSubmitLogin();
        }

        private void HandleSubmitLogin()

        {
            if(!IsValidLogin())
                return;

            Program.frmChinh.HienThiMenu();


            // Close login tab leave mdi screen blank
            this.Close();

        }


        private Boolean IsValidLogin()
        {
            // Validate 
            if (inputTaiKhoan.Text.Trim() == "" || inputPassword.Text.Trim() == "")
            {
                Msg.Warm("Tài khoản và mật khẩu không được để trống");
                return false;
            }

            Program.mlogin = inputTaiKhoan.Text;
            Program.password = inputPassword.Text;

            if (Program.KetNoi() == Database.Connection.Fail)
            {
                return false;
            }
            Program.mChiNhanh = cmbChiNhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            String cmd = "EXEC SP_LayThongTinNhanVien '" + inputTaiKhoan.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null) return false;
            Program.myReader.Read();

            // Ma nhan vien doi voi nhan vien, CMND doi voi khach hang
            try
            {
                Program.username = Program.myReader["MANV"].ToString();
                Program.mHoTen = Program.myReader["HOTEN"].ToString();
                Program.mGroup = Program.myReader["TENNHOM"].ToString();
                if (Program.username == null)
                    Program.username = "";
                if (Program.mHoTen == null)
                    Program.mHoTen = "";
                if (Program.mGroup == null)
                    Program.mGroup = "";
                String group = Program.mGroup.ToUpper();
                if (!(group == "NGANHANG" || group == "CHINHANH" || group == "KHACHHANG"))
                {
                    Msg.Warm($"Tài khoản thuộc nhóm {Program.mGroup} không có quyền truy cập dữ liệu");
                    return false;
                }
            }
            catch { }

            Program.myReader.Close();
            Program.conn.Close();
            return true;
        }



        // Improve form movement by handle key event
        private void inputPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (inputTaiKhoan.Text == "" && inputPassword.Text != "")
                {
                    inputTaiKhoan.Focus();
                }
                if (inputTaiKhoan.Text != "" && inputPassword.Text != "")
                {
                    HandleSubmitLogin();
                }

            }


        }

        // Improve form movement 

        private void inputTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (inputTaiKhoan.Text != "" && inputPassword.Text == "")
                {
                    inputPassword.Focus();
                }
                if (inputTaiKhoan.Text != "" && inputPassword.Text != "")
                {
                    HandleSubmitLogin();
                }
            }
        }

        // Improve UI

        private void CustomLoad()
        {

            // Make chi nhanh combox  non editable just able to select specfic define row
            cmbChiNhanh.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btnDangNhap.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangNhap.Appearance.Options.UseBackColor = true;

            // Make user unable to close tab
            this.ControlBox = false;

            StartPosition = FormStartPosition.CenterScreen;
            // Make form content center of parrent mdi
            panelContainer.Location = new Point(
                this.ClientSize.Width / 2 - panelContainer.Size.Width / 2,
                this.ClientSize.Height / 2 - panelContainer.Size.Height / 2);
            panelContainer.Anchor = AnchorStyles.None;
        }
    }




}
