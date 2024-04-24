using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using BankReplication.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static BankReplication.utils.Validate;
enum FormAction { None, Add, Edit };

namespace BankReplication.form
{
    public partial class formNhanVien : SimpleForm
    {
        private Invoker commandController = new Invoker();
        private String macn;
        private int topRowIndex;
        private int focusedRowHandle;
        private FormAction formAction;

        public formNhanVien()
        {
            InitializeComponent();
        }

        private void formNhanVien_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            // Stop checking for foreign key constraint
            nhanVienDS1.EnforceConstraints = false;


            // Load data base on user login connection avoid using login and password in dataset 
            LoadNhanVien(Program.connstr);
            LoadCmbChiNhanh();
            SetFormState();
            
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
                // Load data
                LoadNhanVien(Program.connstr);
            }

        }

        // ========================> Utils method <========================

        public void InitNewRowData()
        {
            macn = LayMaCN();
            MACNTextEdit.Text = macn;
            trangThaiXoaCheckBox.Checked = false;
            if (macn.ToString().Trim() == "") return;
        }
        public void SaveViewRowToBindingSource()
        {
            // Make sure data display in side bar form apply to actual row in binding source
            // May be binding SODT not work as expect or not allow invalid data

            DataRowView current = (DataRowView)nhanVienBds.Current;
            current.Row["MANV"] = MANVTextEdit.Text;
            current.Row["HO"] = HOTextEdit.Text;
            current.Row["TEN"] = TENTextEdit.Text;
            current.Row["DIACHI"] = DIACHITextEdit.Text;
            current.Row["CMND"] = CMNDTextEdit.Text;
            current.Row["PHAI"] = PHAIComboBox.SelectedValue;
            current.Row["SODT"] = SODTTextEdit.Text;
            current.Row["MACN"] = MACNTextEdit.Text;
            current.Row["TrangThaiXoa"] = trangThaiXoaCheckBox.Checked;
        }
        private String LayMaCN()
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
                if (Program.KetNoi() == Database.Connection.Fail) return "";
                try
                {
                    macn = Program.FetchMACNFromDB();
                }
                catch (Exception ex)
                {
                    Msg.Error("Lỗi không tìm thấy mã chi nhánh\n" + ex.Message);
                }
            }
            return macn;
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
                Msg.Warm("Trường lỗi: " + fieldName + "\nLỗi: " + ex.Message, "Dữ liệu được nhập không hợp lệ");
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
                Msg.Warm("Trường lỗi: " + fieldName + "\nLỗi: " + ex.Message, "Dữ liệu được nhập không hợp lệ");
                field.Focus();

                return true;
            }
            return false;
        }

        private Boolean InvalidNewEmployee()
        {
            if (InvalidField(MANVTextEdit, "Mã nhân viên", validateMANV)) return true;
            if (InvalidField(HOTextEdit, "Họ", validateHo)) return true;
            if (InvalidField(TENTextEdit, "Tên", validateTen)) return true;

            // Track not allow to duplicate because unique key
            if (InvalidField(CMNDTextEdit, "Số chứng minh nhân dân", validateCMND)) return true;
            if (InvalidField(DIACHITextEdit, "Địa chỉ", validateDiaChi)) return true;
            if (InvalidField(PHAIComboBox, "Giới tính", validatePhai)) return true;

            // SDT Allow null!!! change db contraint
            if (InvalidField(SODTTextEdit, "Số điện thoại", validateSDT)) return true;
            if (InvalidField(MACNTextEdit, "Mã chi nhánh", validateMACN)) return true;

            if (InvalidDuplicateEmployeeId(MANVTextEdit)) return true;
            if (InvalidDuplicateCMND()) return true;
            return false;
        }

        private Boolean InvalidEditEmployee()
        {
            if (InvalidField(MANVTextEdit, "Mã nhân viên", validateMANV)) return true;
            if (InvalidField(HOTextEdit, "Họ", validateHo)) return true;
            if (InvalidField(TENTextEdit, "Tên", validateTen)) return true;

            if (InvalidField(CMNDTextEdit, "Số chứng minh nhân dân", validateCMND)) return true;
            if (InvalidField(DIACHITextEdit, "Địa chỉ", validateDiaChi)) return true;
            if (InvalidField(PHAIComboBox, "Giới tính", validatePhai)) return true;

            if (InvalidField(SODTTextEdit, "Số điện thoại", validateSDT)) return true;
            if (InvalidField(MACNTextEdit, "Mã chi nhánh", validateMACN)) return true;


            if (!MANVTextEdit.OldEditValue.ToString().Trim().Equals(MANVTextEdit.EditValue.ToString().Trim()))
            {
                if (InvalidDuplicateEmployeeId(MANVTextEdit)) return true;
            }
            if (!CMNDTextEdit.OldEditValue.ToString().Trim().Equals(CMNDTextEdit.EditValue.ToString().Trim()))
            {
                if (InvalidDuplicateCMND()) return true;
            }
            return false;
        }

        private Boolean InvalidDuplicateCMND()
        {

            // Search for row in current bds to avoid dataRowView have same value of CMND
            // If two row have same CMND (when edit) they must have same MaNV
            foreach (DataRowView row in nhanVienBds)
            {
                String cmndCurrentRow = row["CMND"].ToString();
                String manvCurrentRow = row["MaNV"].ToString();
                if (cmndCurrentRow == CMNDTextEdit.Text && MANVTextEdit.Text != manvCurrentRow)
                {
                    Msg.Warm("Số CMND không được trùng với nhân viên khác trong cùng chi nhánh", "Dữ liệu nhập không hợp lệ");
                    CMNDTextEdit.Focus();
                    return true;
                }
            }
            return false;
        }
        private Boolean InvalidDuplicateEmployeeId(DevExpress.XtraEditors.TextEdit field)
        {
            // Kiểm tra mã nhân viên đã được sử dụng trước chưa để phục vụ cho việc tạo nhân viên mới
            // với mã không bị trùng với mã nhân viên của các nhân viên khác 
            if (Program.KetNoi() == Database.Connection.Fail)
            {
                Msg.Error("Lỗi kết nối với với cơ sở dữ liệu");
                return true;
            }

            if (Program.IsEmployeeExist(field.Text))
            {
                Msg.Warm("Mã nhân viên đã tồn tại");
                field.Focus();
                return true;

            }
            return false;
        }



        // ===============================> Form Data <================================

        private void LoadNhanVien(String connstr)
        {
            try
            {
                nhanVienTableAdapter1.Connection.ConnectionString = connstr;
                gD_GOIRUTTableAdapter.Connection.ConnectionString = connstr;
                gD_CHUYENTIENTableAdapter.Connection.ConnectionString = connstr;

                // TODO: Add filter to deleted employee


                nhanVienTableAdapter1.Fill(nhanVienDS1.NhanVien);


                this.gD_GOIRUTTableAdapter.Fill(this.nhanVienDS1.GD_GOIRUT);
                this.gD_CHUYENTIENTableAdapter.Fill(this.nhanVienDS1.GD_CHUYENTIEN);
            }
            catch (Exception ex)
            {

                Msg.Error("Lỗi tải về dữ liệu\n" + ex.Message, "");
            }

        }
        private void CommitChangeNhanVien()
        {
            try
            {
                nhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;
                nhanVienTableAdapter1.Update(nhanVienDS1.NhanVien);
            }
            catch (Exception ex)
            {
                Msg.Error("Ghi dữ liệu không thành công\n" + ex.Message);
            }
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
            HandleCancel();
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HandleRedo();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HandleReload();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void btnUndo_ItemClick(object sender, EventArgs e)
        {
            HandleUndo();
        }


        private void btnLuu_ItemClick(object sender, EventArgs e)
        {
            HandleSave();
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HandleDelete();
            // Not reset form state avoid case invalid field input 
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



        // =================> Handle function for perform action details for event call <======================
        public override void HandleDelete()
        {
            if (formAction != FormAction.None) return;
            if (nhanVienBds.Position < 0)
                return;
            String manv = "";
            if (gD_CHUYENTIENBds.Count > 0)
            {
                Msg.Warm("Không thể xóa nhân viên này vì đã lập giao dịch chuyển tiền" );
                return;
            }
            if (gD_GOIRUTBds.Count > 0)
            {
                Msg.Warm("Không thể xóa nhân viên này vì đã lập giao dịch gửi rút" );
                return;
            }

            
            if (Msg.InforConfirm("Bạn có thực sự muốn xóa nhân viên này?") == DialogResult.OK)
            {
                try
                {
                    manv = ((DataRowView)nhanVienBds[nhanVienBds.Position])["MANV"].ToString();
                    commandController.Execute(new DeleteCommand(nhanVienBds, (DataRowView)nhanVienBds.Current));
                    CommitChangeNhanVien();
                    SetFormState(FormAction.None);
                }
                catch (Exception ex)
                {
                    Msg.Error("Lỗi không thể xóa nhân viên\n" + ex.Message);
                    LoadNhanVien(Program.connstr);
                    nhanVienBds.Position = nhanVienBds.Find("MANV", manv);
                }
            }
        }


        public void HandleReload()
        {
            HandleCancel();
            gcNhanVien.Enabled = false;
            HandleRefresh();

        }
        public void HandleRefresh()
        {
            SavePosition();
            LoadNhanVien(Program.connstr);
            RevertLastPosition();
        }
        public override void HandleAdd()
        {
            if (!InvalidNewEmployee())
            {
                SaveViewRowToBindingSource();
                commandController.Execute(new AddCommand(nhanVienBds, (DataRowView)nhanVienBds.Current));
                CommitChangeNhanVien();
                SetFormState(FormAction.None);
                gvNhanVien.Focus();
            }
        }
        private void HandleCancel()
        {
            if (formAction == FormAction.Add)
            {

                nhanVienBds.RemoveCurrent();
                SetFormState(FormAction.None);
                RevertLastPosition();

            }
            if (formAction == FormAction.Edit)
            {

                DataRowView current = (DataRowView)nhanVienBds.Current;
                SetFormState(FormAction.None);
                RevertLastPosition();
            }
        }
        private void HandleEdit()
        {
            if (!InvalidEditEmployee())
            {
                commandController.Execute(new EditCommand(nhanVienBds));
                CommitChangeNhanVien();
                SetFormState(FormAction.None);
                gvNhanVien.Focus();
            }
        }
        private void HandleUndo()
        {
            HandleCancel();
            commandController.Undo();
            HandleReload();
            gvNhanVien.Focus();
            SetFormState();
        }
        private void HandleRedo()
        {
            HandleCancel();
            commandController.Redo();
            HandleReload();
            gvNhanVien.Focus();
            SetFormState();
        }
        private void HandleSave()
        {

            if (formAction == FormAction.None)
            {
                CommitChangeNhanVien();
                HandleReload();
            }
            if (formAction == FormAction.Add)
                HandleAdd();
            if (formAction == FormAction.Edit)
                HandleEdit();

        }

        // ================================================> UI Perform <========================================================
        public void OpenEditSideBar()
        {
            SavePosition();
            SetFormState(FormAction.Edit);
            ResetSideBar();
        }
        private void ResetSideBar()
        {
            MANVTextEdit.Focus();

            Boolean cmbIsNotLoadGender = PHAIComboBox.DisplayMember == "";
            this.PHAIComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cmbIsNotLoadGender)
            {
                List<string> gioiTinh = new List<string>();
                String[] x = { "Nam", "Nữ" };
                gioiTinh.AddRange(x);
                PHAIComboBox.DataSource = gioiTinh;
            }
        }


        private void SavePosition()
        {
            topRowIndex = gvNhanVien.TopRowIndex;
            focusedRowHandle = gvNhanVien.FocusedRowHandle;

        }
        private void RevertLastPosition()
        {
            // Revert position from SavePosition();
            gvNhanVien.FocusedRowHandle = focusedRowHandle;
            gvNhanVien.TopRowIndex = topRowIndex;

            gcNhanVien.Enabled = true;
            gvNhanVien.Focus();
        }
        public void OpenCreationSideBar()
        // Mở form thêm dữ liệu chưa lưu lại
        {
            SavePosition();
            SetFormState(FormAction.Add);
            nhanVienBds.AddNew();
            ResetSideBar();
            InitNewRowData();
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
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
            btnExit.Enabled = true;
            btnHuy.Enabled = false;
            btnReload.Enabled = true;

            btnLuu.Enabled = false;
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


                    btnHuy.Enabled = true;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;

                }

                if (formAction == FormAction.Edit)
                {
                    gcNhanVien.Enabled = false;
                    btnHuy.Enabled = true;
                    sidePanel.Visible = true;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                }
                // Final condition require button to become enable 
                if (nhanVienBds.Position == -1)
                {
                    btnXoa.Enabled = false;
                    btnChuyenCN.Enabled = false;
                }
                if (commandController.Redoable())
                    btnRedo.Enabled = true;
                if (commandController.Undoable())
                    btnUndo.Enabled = true;


            }
        }

        private void formNhanVien_KeyDown(object sender, KeyEventArgs e)
        // Use for all text edit field in creation new employee or edit employee.
        {
            if (e.KeyCode == Keys.Escape)
                HandleCancel();
            if (e.KeyCode == Keys.F5)
                HandleReload();
            if (e.KeyCode == Keys.Delete)
                HandleDelete();
            if (e.Control)
            {
                if (e.KeyCode == Keys.S)
                    HandleSave();
                if (e.KeyCode == Keys.Z)
                    HandleUndo();
                if (e.KeyCode == Keys.Y)
                    HandleRedo();
            }
        }

        private void InputFields_KeyDown(object sender, KeyEventArgs e)
        {
            // Use for all text edit in form 
            if (e.KeyCode == Keys.Enter)
            {
                HandleSave();
            }

        }

        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maNVCu = ((DataRowView)nhanVienBds[nhanVienBds.Position]).Row["MANV"].ToString();
            String cmnd= ((DataRowView)nhanVienBds[nhanVienBds.Position]).Row["CMND"].ToString();
            String maNVMoi = Program.layMaNVChiNhanhKhac(cmnd);
            // Use while loop until input is validate not exist in other branch 
            if(maNVMoi == null)
                maNVMoi= XtraInputBox.Show("Nhập mã nhân viên mới", "Mã nhân viên mới", ""); 
            commandController.Execute(new ChuyenCNCommand(Program.connstr, maNVCu, maNVMoi , HandleRefresh));
        }


    }





}

