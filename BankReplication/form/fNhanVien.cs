using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using static BankReplication.utils.Validate;
enum FormAction { None, Add, Edit };

namespace BankReplication.form
{
    public partial class formNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private String macn;
        private int vitri;
        private FormAction actionState;
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
            loadNhanVien(Program.connstr);

            this.cmbChiNhanh.DataSource = Program.bds_dspm;
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            this.cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup.ToUpper() == "NGANHANG")
            {
                // Make chi nhanh non editable
                cmbChiNhanh.DropDownStyle = ComboBoxStyle.DropDownList;
                // Can change server to load data 
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }
            setFormState();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            String manv = "";
            if (gD_CHUYENTIENBds.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập giao dịch chuyển tiền", "", MessageBoxButtons.OK);
                return;
            }
            if (gD_GOIRUTBds.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập giao dịch gửi rút", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try

                {
                    String result;
                    manv= ((DataRowView)nhanVienBds[nhanVienBds.Position])["MANV"].ToString();
                    nhanVienBds.RemoveCurrent();
                    nhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;
                    nhanVienTableAdapter1.Update(nhanVienDS1.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không thể xóa nhân viên\n" + ex.Message, "", MessageBoxButtons.OK);
                    nhanVienTableAdapter1.Fill(nhanVienDS1.NhanVien);
                    nhanVienBds.Position = nhanVienBds.Find("MANV", manv);
                }
            }

        }




        private void resetSideBarForm()
        {
            mANVTextEdit.Focus();
            mACNTextEdit.Text = macn;
            trangThaiXoaCheckBox.Checked = false;

            if(pHAIComboBox.DataSource == null)
            {

            List<string> gioiTinh= new List<string>();
            String[] x = { "Nam", "Nữ" };
            gioiTinh.AddRange(x);
            pHAIComboBox.DataSource = gioiTinh; 
            }



        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            macn = getMACN();
            if (macn.ToString().Trim() == "") return;

            // Track point cusor when undo action
            vitri = nhanVienBds.Position;
            setFormState(FormAction.Add);
            nhanVienBds.AddNew();
            resetSideBarForm();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

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
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                // Load data
                loadNhanVien(Program.connstr);
            }

        }

        // ========================> Utils method <========================

        private String getMACN()
        {
            String macn = "";
            //            macn = nhanVienDS1.NhanVien.Rows[0]["MACN"].ToString();
            try
            {
                macn = ((DataRowView)nhanVienBds[0])["MACN"].ToString();
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

        private void setFormState(FormAction state)
        {
            actionState = state;
            setFormState();
        }
        private void setFormState()
        {
            // Reset state 
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnUndo.Enabled = true;
            btnRedo.Enabled = true;
            btnLuu.Enabled = true;
            btnExit.Enabled = true;
            btnReload.Enabled = true;

            sidePanel.Visible = false;
            gridControl1.Enabled = true;

            if (Program.mGroup.ToUpper() == "NGANHANG")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnUndo.Enabled = false;
                btnRedo.Enabled = false;
                btnLuu.Enabled = false;
            }
            else
            {

                if (actionState == FormAction.Add)
                {

                    sidePanel.Visible = true;
                    gridControl1.Enabled = false;


                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                   
                }

                if (actionState == FormAction.Edit)
                {
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                }
                if (nhanVienBds.Count == 0)
                {
                    btnXoa.Enabled = false;
                }
            }
        }


        private void loadNhanVien(String connstr)
        {
            nhanVienTableAdapter1.Connection.ConnectionString = connstr;
            gD_GOIRUTTableAdapter.Connection.ConnectionString = connstr;
            gD_CHUYENTIENTableAdapter.Connection.ConnectionString = connstr;

            // Must fill NhanVien first 
            nhanVienTableAdapter1.Fill(nhanVienDS1.NhanVien);


            this.gD_GOIRUTTableAdapter.Fill(this.nhanVienDS1.GD_GOIRUT);
            this.gD_CHUYENTIENTableAdapter.Fill(this.nhanVienDS1.GD_CHUYENTIEN);

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadNhanVien(Program.connstr);
            // TODO: Reload will reset cusor position
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (validateThem())
            {


            nhanVienBds.EndEdit();
            // Reread current selected item and display in to grid 
            nhanVienBds.ResetCurrentItem();
            nhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;
            nhanVienTableAdapter1.Update(nhanVienDS1.NhanVien);
            setFormState(FormAction.None);
            }

        }

        private Boolean validateThem()
        {

            try
            {
                validateMANV(mANVTextEdit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã nhân viên - " +  ex.Message, "Dữ liệu được nhập không hợp lệ" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                mANVTextEdit.Focus();
                return false;
            }
            try
            {
                validateHo(hOTextEdit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Họ - " +  ex.Message, "Dữ liệu được nhập không hợp lệ" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                hOTextEdit.Focus();
                return false;
            }
            try
            {
                validateTen(tENTextEdit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên - " +  ex.Message, "Dữ liệu được nhập không hợp lệ" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                tENTextEdit.Focus();
                return false;
            }
            try
            {
            validateCMND(cMNDTextEdit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CMND - " +  ex.Message, "Dữ liệu được nhập không hợp lệ" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                cMNDTextEdit.Focus();
                return false;
            }
            try
            {
            validateDiaChi(dIACHITextEdit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Địa chỉ - " +  ex.Message, "Dữ liệu được nhập không hợp lệ" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                dIACHITextEdit.Focus();
                return false;
            }
            try
            {
           validatePhai(pHAIComboBox.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phái - " +  ex.Message, "Dữ liệu được nhập không hợp lệ" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
           validateSDT(sODTTextEdit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phái - " +  ex.Message, "Dữ liệu được nhập không hợp lệ" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                sODTTextEdit.Focus();
                return false;
            }
            try
            {
            validateMACN(mACNTextEdit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã chi nhánh - " +  ex.Message, "Dữ liệu được nhập không hợp lệ" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                mACNTextEdit.Focus();
                return false;
            }

            return true;
        }



        private void btnUndo_Click(object sender, EventArgs e)
        {

            // TODO: use stack to reimplement 
            nhanVienBds.CancelEdit();

        }


        // =================================> Validate <=========================

    }



}