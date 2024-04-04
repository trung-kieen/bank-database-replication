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
        private Invoker commandController = new Invoker();
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
            LoadNhanVien(Program.connstr);
            LoadCmbChiNhanh();

            SetFormState();

        }


        private void ResetSideBar()
        {
            mANVTextEdit.Focus();

            Boolean cmbIsNotLoadGender = pHAIComboBox.DisplayMember == "";
            this.pHAIComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cmbIsNotLoadGender)
            {
                List<string> gioiTinh = new List<string>();
                String[] x = { "Nam", "Nữ" };
                gioiTinh.AddRange(x);
                pHAIComboBox.DataSource = gioiTinh;
            }
        }

        public void Duplicate()
        {
            DataRowView currentRow = (DataRowView) nhanVienBds.Current;
            commandController.Execute(new AddCommand(nhanVienBds, currentRow));
            gvNhanVien.Focus();

        }
        public void OpenCreationSideBar()
            // Mở form thêm dữ liệu chưa lưu lại
        {
            SetFormState(FormAction.Add);
            nhanVienBds.AddNew();
            ResetSideBar();
            InitNewRowData();
        }
        public void InitNewRowData()
        {
            macn = getMaCN();
            mACNTextEdit.Text = macn;
            trangThaiXoaCheckBox.Checked = false;
            if (macn.ToString().Trim() == "") return;
        }

        public void OpenEditSideBar()
        {
            
            SetFormState(FormAction.Edit);
            ResetSideBar();
        }
        public override void HandleAdd()
        {
            if (!InvalidNewEmployee())
            {

                //                nhanVienBds.EndEdit();
                // Reread current selected item and display in to grid 
                //                nhanVienBds.ResetCurrentItem();

                SaveViewRowToBindingSource();
                commandController.Execute(new AddCommand(nhanVienBds, (DataRowView)nhanVienBds.Current));
                    
//                nhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;
//                nhanVienTableAdapter1.Update(nhanVienDS1.NhanVien);
                SetFormState(FormAction.None);
            }
        }

        public void SaveViewRowToBindingSource()
        {
            // Make sure data display in side bar form apply to actual row in binding source
            // May be binding SODT not work as expect or not allow invalid data

            DataRowView current = (DataRowView)nhanVienBds.Current;
            current.Row["MANV"] = mANVTextEdit.Text;
            current.Row["HO"] = hOTextEdit.Text;
            current.Row["TEN"] = tENTextEdit.Text;
            current.Row["DIACHI"] = dIACHITextEdit.Text;
            current.Row["CMND"] = cMNDTextEdit.Text;
            current.Row["PHAI"] = pHAIComboBox.SelectedValue;
            current.Row["SODT"] = sODTTextEdit.Text;
            current.Row["MACN"] = mACNTextEdit.Text;
            current.Row["TrangThaiXoa"] = trangThaiXoaCheckBox.Checked;
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
                LoadNhanVien(Program.connstr);
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


        private void SetFormState(FormAction state)
        {
            formAction = state;
            SetFormState();
        }
        private void SetFormState()
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
            gcNhanVien.Enabled = true;

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
                    gcNhanVien.Enabled = false;


                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;

                }

                if (formAction == FormAction.Edit)
                {
                    sidePanel.Visible = true;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                }
                // Final condition require button to become enable 
                if (nhanVienBds.Count == 0)
                    btnXoa.Enabled = false;
                if (!commandController.Redoable())
                    btnRedo.Enabled = false;
                if (!commandController.Undoable())
                    btnUndo.Enabled = false;


            }
        }




        private Boolean InvalidField(System.Windows.Forms.ComboBox comboBox, String fieldName, Action<String> validatePerform)
        {
            // Hiển thị thông báo lỗi cho dữ liệu nhập từ ComboBox  lên màn hình, trả về giá trị True
            // để chương trình biết là giá trị của người dùng đang nhập là không hợp lệ
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
            // Hiển thị thông báo lỗi cho dữ liệu nhập từ Field TextEdit lên màn hình, trả về giá trị True
            // để chương trình biết là giá trị của người dùng đang nhập là không hợp lệ
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
            // Kiểm tra mã nhân viên đã được sử dụng trước chưa để phục vụ cho việc tạo nhân viên mới
            // với mã không bị trùng với mã nhân viên của các nhân viên khác 
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



        // ===============================> Load data <================================
        
        private void LoadNhanVien(String connstr)
        {
            nhanVienTableAdapter1.Connection.ConnectionString = connstr;
            gD_GOIRUTTableAdapter.Connection.ConnectionString = connstr;
            gD_CHUYENTIENTableAdapter.Connection.ConnectionString = connstr;

            // Must fill NhanVien first 
            nhanVienTableAdapter1.Fill(nhanVienDS1.NhanVien);


            this.gD_GOIRUTTableAdapter.Fill(this.nhanVienDS1.GD_GOIRUT);
            this.gD_CHUYENTIENTableAdapter.Fill(this.nhanVienDS1.GD_CHUYENTIEN);

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
                cmbChiNhanh.DropDownStyle = ComboBoxStyle.DropDownList;
                // Can change server to load data 
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }

        }
        // ===============================> End load data <================================

        #region event_region


        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            commandController.Redo();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            gcNhanVien.Enabled = false;

            // Track griv view cusor poistion
            var topRowIndex = gvNhanVien.TopRowIndex;
            var focusedRowHandle = gvNhanVien.FocusedRowHandle;


            // TODO: Reload will reset cusor position
            LoadNhanVien(Program.connstr);

            //  
            gvNhanVien.FocusedRowHandle = focusedRowHandle;
            gvNhanVien.TopRowIndex = topRowIndex;

            gcNhanVien.Enabled = true;
            gvNhanVien.Focus(); 
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void btnUndo_ItemClick(object sender, EventArgs e)
        {
            commandController.Undo();
        }


        private void btnLuu_ItemClick(object sender, EventArgs e)
        {

            if(formAction == FormAction.Add)
            {
                HandleAdd();
            }

            if(formAction == FormAction.None)
            {
                CommitChangeNhanVien();
            }
        }
        private void CommitChangeNhanVien()
        {
                    nhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;
                    nhanVienTableAdapter1.Update(nhanVienDS1.NhanVien);
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            commandController.Execute(new DeleteCommand(nhanVienBds,(DataRowView) nhanVienBds.Current));
        }
        #endregion

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenCreationSideBar();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            OpenEditSideBar();
        }
    }



}

