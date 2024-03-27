using System;
using System.Data;
using System.Windows.Forms;

namespace BankReplication.form
{
    public partial class formNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private String macn;
        private Int32 vitri;
        public formNhanVien()
        {
            InitializeComponent();

            this.colTrangThaiXoa.Visible = false;
            // Make user unable to close tab
            this.ControlBox = false;

        }



        private void formNhanVien_Load(object sender, EventArgs e)
        {

            // Stop checking for foreign key constraint
            nhanVienDS1.EnforceConstraints = false;

            // Load data base on user login connection avoid using login and password in dataset 
            nhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;
            gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;

            // Must fill NhanVien first 
            nhanVienTableAdapter1.Fill(nhanVienDS1.NhanVien);


            this.gD_GOIRUTTableAdapter.Fill(this.nhanVienDS1.GD_GOIRUT);
            this.gD_CHUYENTIENTableAdapter.Fill(this.nhanVienDS1.GD_CHUYENTIEN);

            this.cmbChiNhanh.DataSource = Program.bds_dspm;
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            this.cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "NGANHANG")
            {
                // Can change server to load data 
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }
            resetButtonState();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            nhanVienBindingSource.RemoveCurrent();
            // TODO: save to stack
        }



        private void btnThem_Click(object sender, EventArgs e)
        {

            macn = getMACN();
            if (macn.ToString().Trim() == "") return;

            // Track point cusor when undo action
            vitri = nhanVienBindingSource.Position;
            formPanel.Visible = true;
            gridControl1.Enabled = false;

            btnSua.Enabled = btnXoa.Enabled = false;

            nhanVienBindingSource.AddNew();
            mANVTextEdit.Focus();
            mACNTextEdit.Text = macn;
            trangThaiXoaCheckBox.Checked = false;

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        // ========================> Utils method <========================

        private String  getMACN()
        {
            String macn = "";
            //            macn = nhanVienDS1.NhanVien.Rows[0]["MACN"].ToString();
            try
            {
                macn = ((DataRowView)nhanVienBindingSource[0])["MACN"].ToString();
                if (macn.ToString().Trim() == "")
                {
                    // Khi khong co hang nao de lay ma chi nhanh => tu sinh ra loi
                    throw new Exception("MACN not allow to null");
                }
            }
            catch
            {
                if (Program.KetNoi() == 0) return "";
                try
                {
                    macn = fetchMACNFromDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không tìm thấy mã chi nhánh\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            return macn;
        }

        private String fetchMACNFromDB()
        {
            Program.myReader = Program.ExecSqlDataReader("SELECT MACN FROM ChiNhanh");
            if (Program.myReader == null) throw new Exception("Chinh nhanh khong ton tai");
            Program.myReader.Read();

            String macn = Program.myReader.GetString(0);
            Program.myReader.Close();
            return macn;
        }

        private void resetButtonState()
        {
            if (Program.mGroup == "NGANHANG")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnUndo.Enabled = btnRedo.Enabled = false;

            }
        }

    }


}