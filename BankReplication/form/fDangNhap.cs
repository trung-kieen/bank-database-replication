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
        private String conn_publisherStr = ""; 


        public int KetNoiCSDLGoc()
        {
            // Close old connection avoid system close connection time out 
            if(conn_publisher !=null && conn_publisher .State == System.Data.ConnectionState.Open)
            {
                conn_publisher .Close(); 
            }
            try
            {
                conn_publisherStr = "Data Source=" + Program.servername
                                + ";Initial Catalog=" + Program.database
                                + ";User ID=" + Program.mlogin
                                + ";password=" + Program.password;
                conn_publisher .ConnectionString = conn_publisherStr;
                conn_publisher .Open();
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
        {
            StartPosition = FormStartPosition.CenterScreen; 
            // Make form content center of parrent mdi
            panelContainer.Location = new Point(
                this.ClientSize.Width / 2 - panelContainer.Size.Width / 2,
                this.ClientSize.Height / 2 - panelContainer.Size.Height / 2);
            panelContainer.Anchor = AnchorStyles.None;


            if (KetNoiCSDLGoc() == 0) return;
            if(LayDSPM("SELECT * FROM uv_GetSubcribers") == 1)
            {
            cmbChiNhanh.SelectedIndex = 1;
            cmbChiNhanh.SelectedIndex = 0;
            }


        }


        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_CheckedChanged(object sender, EventArgs e)
        {
            MdiParent.Close();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch  {
                MessageBox.Show("Lỗi thiết lập tên server");
            }
        
        }


    }

}
