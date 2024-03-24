using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace BankReplication.form
{
    public partial class formDangNhap : DevExpress.XtraEditors.XtraForm
    {


        // Connection for this login form only 
        private SqlConnection conn_publisher = new SqlConnection();
        private String conn_connection_string = ""; 


        public int KetNoiCSDLGoc()
        {
            // Close old connection avoid system close connection time out 
            if(conn_publisher !=null && conn_publisher .State == System.Data.ConnectionState.Open)
            {
                conn_publisher.Close(); 
            }
            try
            {
                conn_connection_string = "Data Source=" + Program.servername
                                + ";Initial Catalog=" + Program.database
                                + ";User ID=" + Program.mlogin
                                + ";password=" + Program.password;
                conn_publisher.ConnectionString = conn_connection_string;
                conn_publisher.Open();
                // Success
                return 1;
            }
            catch (Exception e) {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                // Error
                return 0;
            }
        }


        private int LayDSPM(String cmd )
        {
            DataTable dataTable = new DataTable();
            if(conn_publisher.State == ConnectionState.Closed)
            {
                conn_publisher.Open();
            }

            try
            {

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conn_publisher);
            dataAdapter.Fill(dataTable);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dataTable;
            cmbChiNhanh.DataSource = dataTable;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách các chi nhánh\nHãy kiểm tra bảng ảo uv_GetSubscribers trong cơ sở dữ liệu");
                conn_publisher.Close();
                return 0;
            }
        }
        public formDangNhap()
        {
            InitializeComponent();

            CustomLoad();
        }

        private void CustomLoad()
        {

            // Make chi nhanh non editable
            cmbChiNhanh.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btnDangNhap.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangNhap.Appearance.Options.UseBackColor = true;


        }
        private void fDangNhap_Load(object sender, EventArgs e)
            // Lay danh sach cac phan manh len combo box 
        {
            StartPosition = FormStartPosition.CenterScreen; 
            // Make form content center of parrent mdi
            panelContainer.Location = new Point(
                this.ClientSize.Width / 2 - panelContainer.Size.Width / 2,
                this.ClientSize.Height / 2 - panelContainer.Size.Height / 2);
            panelContainer.Anchor = AnchorStyles.None;


          if(Program.bds_dspm.DataSource == null)
            {
           LoadChiNhanh();
            }


        }

        private void LoadChiNhanh()
        {
            if (KetNoiCSDLGoc() == 0) return;
            if(LayDSPM("SELECT * FROM uv_GetSubcribers") == 1)
            {
            cmbChiNhanh.SelectedIndex = 1;
            cmbChiNhanh.SelectedIndex = 0;
            }

        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Thoat chuong trinh khi nguoi dung chon nut thoat trong form dang nhap
            MdiParent.Close();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Luu lai chi nhanh duoc chon vao bien toan cuc
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch  {
                MessageBox.Show("Lỗi thiết lập tên server");
            }
        
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            HandleSubmitLogin();
        }
        private void HandleSubmitLogin()
        {
            if(inputTaiKhoan.Text.Trim() == "" || inputPassword.Text.Trim() == "" )
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống");
                return;
            }

            Program.mlogin = inputTaiKhoan.Text;
            Program.password = inputPassword.Text;

            if(Program.KetNoi() == 0)
            {
                return;
            }
            Program.mChiNhanh = cmbChiNhanh.SelectedIndex;
                        Program.mloginDN = Program.mlogin;
                        Program.passwordDN = Program.password;

            String cmd = "EXEC SP_LayThongTinNhanVien '" + inputTaiKhoan.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Tài khoản không có quyền truy cập dữ liệu. Bạn kiểm tra lại tài khoản và mật khẩu");
                    return;
                }
            try
            {
            Program.mHoTen = Program.myReader.GetString(1) != null ?  Program.myReader.GetString(1) : "" ;
            Program.mGroup = Program.myReader.GetString(2) != null ?  Program.myReader.GetString(2) : "" ;
            }
            catch
            {

            }
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.HienThiMenu();

    
        }


        private  SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(cmd, conn_publisher);
            sqlcmd.CommandType = CommandType.Text;
            if(conn_publisher.State == ConnectionState.Closed)
            {
                conn_publisher.Open();
            }
            try
            {
                myReader = sqlcmd.ExecuteReader();
                conn_publisher.Close();
                return myReader;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                conn_publisher.Close();
                return null;
            }
        }


        private void inputPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(inputTaiKhoan.Text == "" && inputPassword.Text != "")
                {
                    inputTaiKhoan.Focus();
                }
                if(inputTaiKhoan.Text != "" && inputPassword.Text != "")
                {
                    HandleSubmitLogin();
                }

            }


        }

        private void inputTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if(inputTaiKhoan.Text != "" && inputPassword.Text == "")
                {
                    inputPassword.Focus();
                }
                if(inputTaiKhoan.Text != "" && inputPassword.Text != "")
                {
                    HandleSubmitLogin();
                }
            }
        }

    }

}
