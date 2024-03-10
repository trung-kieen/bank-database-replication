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

namespace BankReplication.form
{
    public partial class formDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public formDangNhap()
        {
            InitializeComponent();
            AfterLoad();
        }

        private void AfterLoad()
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

        }


        public static int KetNoiCSDLGoc()
        {
            // Close old connection avoid system close connection time out 
            if(Program.conn !=null && Program.conn.State == System.Data.ConnectionState.Open)
            {
                Program.conn.Close(); 
            }
            try
            {
                Program.connstr = "Data Source=" + Program.servername
                                + ";Initial Catalog=" + Program.database
                                + ";User ID=" + Program.mlogin
                                + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e) {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
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
    }
}
