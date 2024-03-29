using BankReplication.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static BankReplication.utils.Validate;
enum FormAction { None, Add, Edit };

namespace BankReplication.form
{
    public partial class formNhanVien : SimpleForm
    //    public partial class formNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private String macn;
        private int vitri;
        private FormAction formAction;

        public formNhanVien()
        {
            InitializeComponent();


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



        private void resetSideBarForm()
        {
            mANVTextEdit.Focus();
            mACNTextEdit.Text = macn;
            trangThaiXoaCheckBox.Checked = false;

            if (pHAIComboBox.SelectedValue.ToString() == "System.Data.DataRowView")
            {

                List<string> gioiTinh = new List<string>();
                String[] x = { "Nam", "Nữ" };
                gioiTinh.AddRange(x);
                pHAIComboBox.DataSource = gioiTinh;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            macn = getMaCN();
            if (macn.ToString().Trim() == "") return;

            // Track point cusor when undo action
            vitri = nhanVienBds.Position;
            setFormState(FormAction.Add);
            nhanVienBds.AddNew();
            resetSideBarForm();
        }

        public override void HandleAdd()
        {
            if (!InvalidNewEmployee())
            {
                nhanVienBds.EndEdit();
                // Reread current selected item and display in to grid 
                nhanVienBds.ResetCurrentItem();
                nhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;
                nhanVienTableAdapter1.Update(nhanVienDS1.NhanVien);
                setFormState(FormAction.None);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            HandleDelete();

        }

        public override void  HandleDelete()
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
                    manv = ((DataRowView)nhanVienBds[nhanVienBds.Position])["MANV"].ToString();
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


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            if(formAction == FormAction.Add)
            {
                HandleAdd();
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

        private String getMaCN()
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
                    macn = Program.FetchMACNFromDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không tìm thấy mã chi nhánh\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            return macn;
        }


        private void setFormState(FormAction state)
        {
            formAction = state;
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

                if (formAction == FormAction.Add)
                {

                    sidePanel.Visible = true;
                    gridControl1.Enabled = false;


                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;

                }

                if (formAction == FormAction.Edit)
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

            if(formAction == FormAction.Add)
            {
                HandleAdd();
            }
        }

        private Boolean InvalidField(System.Windows.Forms.ComboBox comboBox, String fieldName, Action<String> validatePerform)
        {
            try
            {
                validatePerform(comboBox.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trường lỗi: " + fieldName + "\nLỗi: " + ex.Message, "Dữ liệu được nhập không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private Boolean InvalidField(DevExpress.XtraEditors.TextEdit field, String fieldName, Action<String> validatePerform)
        {
            try
            {
                validatePerform(field.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trường lỗi: " + fieldName + "\nLỗi: " + ex.Message, "Dữ liệu được nhập không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                field.Focus();

                return true;
            }
            return false;
        }

        private Boolean InvalidNewEmployee()
        {



            if (InvalidField(mANVTextEdit, "Mã nhân viên", validateMANV)) return true;
            if (InvalidField(hOTextEdit, "Họ", validateHo)) return true;
            if (InvalidField(tENTextEdit, "Tên", validateTen)) return true;

            // Track not allow to duplicate because unique key
            if (InvalidField(cMNDTextEdit, "Số chứng minh nhân dân", validateCMND)) return true;
            if (InvalidField(dIACHITextEdit, "Địa chỉ", validateDiaChi)) return true;
            if (InvalidField(pHAIComboBox, "Giới tính", validatePhai)) return true;

            // SDT Allow null!!! change db contraint
            if (InvalidField(sODTTextEdit, "Số điện thoại", validateSDT)) return true;
            if (InvalidField(mACNTextEdit, "Mã chi nhánh", validateMACN)) return true;

            if (InvalidDuplicateEmployeeId(mANVTextEdit)) return true;
            
        
            return false;
        }

        private Boolean InvalidDuplicateEmployeeId(DevExpress.XtraEditors.TextEdit field)
        {
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối với với cơ sở dữ liệu", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

                if (Program.IsEmployeeExist(field.Text))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    field.Focus();
                    return true;

                }
                return false;
        }


        private void btnUndo_Click(object sender, EventArgs e)
        {

            // TODO: use stack to reimplement 
            nhanVienBds.CancelEdit();

        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }


        // =================================> Validate <=========================

    }



}