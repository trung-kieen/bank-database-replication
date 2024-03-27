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
    public partial class formNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private String macn;
        public formNhanVien()
        {
            InitializeComponent();

            this.colTrangThaiXoa.Visible = false;
            // Make user unable to close tab
            this.ControlBox = false;

        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trangThaiXoaLabel_Click(object sender, EventArgs e)
        {

        }

        private void trangThaiXoaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void formNhanVien_Load(object sender, EventArgs e)
        {
            nhanVienDS1.EnforceConstraints = false;
            // Load data base on login 
            nhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;
            nhanVienTableAdapter1.Fill(nhanVienDS1.NhanVien);
            // TODO: This line of code loads data into the 'nhanVienDS1.GD_GOIRUT' table. You can move, or remove it, as needed.
            gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.nhanVienDS1.GD_GOIRUT);
            // TODO: This line of code loads data into the 'nhanVienDS1.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.nhanVienDS1.GD_CHUYENTIEN);


            // Get ma chi nhanh
            // macn = ((DataRowView)nhanVienBindingSource[0]["MACN"].ToString());
        }
    }
}