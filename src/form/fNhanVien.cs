﻿using DevExpress.XtraGrid.Views.Base;
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
// Author: trung-kieen

/*
 * Form display data of employee provide some feature for user to work with data
 * For provide update UI application need to change FormAction and display button base on each state
 * To provide undo and redo action any action work with data will perform on a Command (see Command.cs)
 * Each action change data: add, edit, delete, transfer employee,... will write change directly to database 
 * not base on default strategy of GridView
 */


namespace BankReplication.form
{
    public partial class formNhanVien : SimpleForm
    {
        private Invoker commandController = new Invoker();
        private String macn;
        private String manv;
        private int topRowIndex;
        private int focusedRowHandle;
        private FormAction formAction;
        private object[] checkPointRowsData;

        public formNhanVien()
        {
            InitializeComponent();
        }


        // ========================> Utils method <========================

        public void InitNewRowData()
        {
            if (macn == null)
                macn = Program.LayMaCN();
            if (macn == null)
            {
                Msg.Error("Lỗi tải mã chi nhánh");
                return;
            }
            if (macn.ToString().Trim() == "") return;
            MACNTextEdit.Text = macn;
            PHAIComboBox.SelectedIndex = 0;
            trangThaiXoaCheckBox.Checked = false;
            GenerateNewId();
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
            current.Row["PHAI"] = PHAIComboBox.Text.ToString();
            current.Row["SODT"] = SODTTextEdit.Text;
            current.Row["MACN"] = MACNTextEdit.Text;
            current.Row["TrangThaiXoa"] = trangThaiXoaCheckBox.Checked;
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


            /*
             * Handle with case when auto generate id for new user is not valid because
             * of other user create employee with this id 
             */
            int maxiumn_regenerate = 5;
            while (InvalidDuplicateEmployeeId(MANVTextEdit))
            {
                GenerateNewId();
                maxiumn_regenerate--;
                if (maxiumn_regenerate == 0)
                {
                    Msg.Warm("Lỗi tải mã nhân viên");
                    MANVTextEdit.Enabled = true; // Allow user to choose employee id
                    break;
                }
            }
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
            int ExistsCode = Int32.Parse(Program.ExecSqlScalar("EXEC SP_TimCMNDNhanVien '" + CMNDTextEdit.Text.Trim() + "'"));
            if (ExistsCode == Database.CheckExist.FoundSameSite)
            {
                Msg.Warm("Số CMND không được trùng với nhân viên cùng chi nhánh", "Dữ liệu nhập không hợp lệ");
                CMNDTextEdit.Focus();
                return true;
            }
            else if (ExistsCode == Database.CheckExist.FoundOtherSite)
            {
                Msg.Warm("Số CMND không được trùng với nhân viên khác chi nhánh khác", "Dữ liệu nhập không hợp lệ");
                CMNDTextEdit.Focus();
                return true;
            }


            /*
             * This handle is deprecate because we lock modify for primary key (MANV) 
             * and foreignkey (CMND) 
             */

            /*
            // Search for row in current bds to avoid dataRowView have same value of CMND
            // If two row have same CMND (when edit) they must have same MaNV
            foreach (DataRowView row in nhanVienBds)
            {
                String cmndCurrentRow = row["CMND"].ToString();
                String manvCurrentRow = row["MaNV"].ToString();
                if (cmndCurrentRow.Trim() == CMNDTextEdit.Text.Trim() && MANVTextEdit.Text.Trim() != manvCurrentRow.Trim())
                {
                    Msg.Warm("Số CMND không được trùng với nhân viên khác trong cùng chi nhánh", "Dữ liệu nhập không hợp lệ");
                    CMNDTextEdit.Focus();
                    return true;
                }
            }
            */
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
                HandleRefresh();
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
                // Can change server to load data 
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }

        }
        // ===============================> End load data <================================




        // =================> Handle function for perform action details for event call <======================
        public void HandleDelete()
        {
            if (formAction != FormAction.None) return;
            if (nhanVienBds.Position < 0)
                return;
            SavePosition();
            if (gD_CHUYENTIENBds.Count > 0)
            {
                Msg.Warm("Không thể xóa nhân viên này vì đã lập giao dịch chuyển tiền");
                return;
            }
            if (gD_GOIRUTBds.Count > 0)
            {
                Msg.Warm("Không thể xóa nhân viên này vì đã lập giao dịch gửi rút");
                return;
            }


            if (Msg.InforConfirm("Bạn có thực sự muốn xóa nhân viên này?") == DialogResult.OK)
            {
                try
                {
                    commandController.Execute(new DeleteCommand(nhanVienBds, (DataRowView)nhanVienBds.Current, HandleRefresh, CommitChangeNhanVien));
                    SetFormState(FormAction.None);
                }
                catch (Exception ex)
                {
                    Msg.Error("Lỗi không thể xóa nhân viên\n" + ex.Message);
                    LoadNhanVien(Program.connstr);
                    RevertLastPosition();
                }
            }
        }


        public void HandleReload()
        {
            HandleCancel();
            gcNhanVien.Enabled = false;
            HandleRefresh();
            gcNhanVien.Enabled = true;
            gvNhanVien.Focus();

        }
        public void HandleRefresh()
        {
            SavePositionByMa();
            LoadNhanVien(Program.connstr);
            RevertLastPositionByMa();
        }
        public void HandleAdd()
        {
            if (!InvalidNewEmployee())
            {
                SaveViewRowToBindingSource();
                nhanVienBds.EndEdit();
                commandController.Execute(new AddCommand(nhanVienBds, (DataRowView)nhanVienBds.Current, HandleRefresh, CommitChangeNhanVien));
                //                CommitChangeNhanVien();
                //                HandleReload();
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
                nhanVienBds.CancelEdit();
                SetFormState(FormAction.None);
                RevertLastPosition();
            }
        }
        private void HandleEdit()
        {
            if (!InvalidEditEmployee())
            {
                PHAIComboBox.EndUpdate();
                SaveViewRowToBindingSource();
                object[] dirtyRowsData = ModelMapper.RowViewToRowList((DataRowView)nhanVienBds.Current);
                commandController.Execute(new EditCommand(nhanVienBds, checkPointRowsData, dirtyRowsData, CommitChangeNhanVien));
                SetFormState(FormAction.None);
                gvNhanVien.Focus();
            }
        }
        private void HandleUndo()
        {
            HandleCancel();
            commandController.Undo();
            SetFormState();
        }
        private void HandleRedo()
        {
            HandleCancel();
            commandController.Redo();
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

        private void HandleChuyenCN()
        {
            String maNVCu = ((DataRowView)nhanVienBds[nhanVienBds.Position]).Row["MANV"].ToString();
            String cmnd = ((DataRowView)nhanVienBds[nhanVienBds.Position]).Row["CMND"].ToString();

            if (Program.KetNoi() == Database.Connection.Fail) return;

            try
            {
                formChuyenNhanVien fChuyenCN = new formChuyenNhanVien(cmnd);
                fChuyenCN.ShowDialog();
                fChuyenCN.BringToFront();
                fChuyenCN.Focus();


                // Rebuild  connection string
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
                // Server name will change so make sure connect to the right server 
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
                Program.connstr = Program.GetConnString();
                if (!fChuyenCN.submit)
                {
                    return;
                }

                macn = Program.LayMaCN();
                commandController.Execute(new ChuyenCNCommand(nhanVienBds, Program.connstr, fChuyenCN.remote_connstr, maNVCu, fChuyenCN.manv_moi, macn, fChuyenCN.macn_moi, HandleRefresh));
                SetFormState();

            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message);
            }
        }



        // ================================================> UI Perform <========================================================
        public void OpenEditSideBar()
        {
            if (Program.mGroup.ToUpper() != "CHINHANH") return;
            DataRowView r = (DataRowView)nhanVienBds.Current;
            PHAIComboBox.SelectedIndex = PHAIComboBox.FindStringExact(r.Row["PHAI"].ToString());
            checkPointRowsData = ModelMapper.RowViewToRowList((DataRowView)nhanVienBds.Current);
            SavePosition();
            SetFormState(FormAction.Edit);
            ResetSideBar();
        }
        private void ResetSideBar()
        {
            if (formAction == FormAction.Edit)
            {
                HOTextEdit.Focus();
            }
            else if (formAction == FormAction.Add)
            {
                MANVTextEdit.Focus();
            }

        }

        /* 
         * Save position on index is not stable when user change filter, sort  so index will not persitence
         * Other wise we can save position base on manv 
         */

        private void SavePosition()
        {

            topRowIndex = gvNhanVien.TopRowIndex;
            focusedRowHandle = gvNhanVien.FocusedRowHandle;

        }
        private void SavePositionByMa()
        {
            manv = ((DataRowView)nhanVienBds[nhanVienBds.Position])["MANV"].ToString(); ;
            topRowIndex = gvNhanVien.TopRowIndex;
        }
        private void RevertLastPositionByMa()
        {
            // Revert position from SavePositionByMa();
            nhanVienBds.Position = nhanVienBds.Find("MANV", manv);
            gvNhanVien.TopRowIndex = topRowIndex;
        }
        private void RevertLastPosition()
        {
            // Revert position from SavePosition();
            gvNhanVien.FocusedRowHandle = focusedRowHandle;
            gvNhanVien.TopRowIndex = topRowIndex;

            gcNhanVien.Enabled = true;
            gvNhanVien.Focus();
        }
        /*  Init new row, allow user to edit new row data
         *  New row is only save if execute method HandleSave
         */
        public void OpenCreationSideBar()
        {
            SavePosition();
            SetFormState(FormAction.Add);
            nhanVienBds.AddNew();
            ResetSideBar();
            InitNewRowData();
        }
        /// <summary>
        /// Generate user id for employee when user want to add an new employee or change employee branch
        /// </summary>
        private void GenerateNewId()
        {
            if (General.AutoAddNewEmployeeID)
            {
                String newId = Program.GetNewEmployeeID();
                if (newId != null && newId.Trim() != "")
                {
                    MANVTextEdit.Enabled = false;
                    MANVTextEdit.Text = newId;
                    HOTextEdit.Focus();
                    return;
                }

            }
            MANVTextEdit.Enabled = true;

        }



        /*
         * Manager ui for form base on state of form (enum FormState) and user priviledge
         * Some button only enable for specific state 
         */
        private void SetFormState(FormAction state)
        {
            formAction = state;
            SetFormState();
        }
        private void SetFormState()
        {
            // Reset state 
            SetDefaultButtonVisible();
            // User of group NGANHANG not allow to change data in branch
            bool userAllowModifyForm = Program.mGroup.ToUpper() == "NGANHANG";
            EnableModifyForm(userAllowModifyForm);

            if (formAction == FormAction.Add)
            {
                FocusSidePanel(true);
                MANVTextEdit.Enabled =
                CMNDTextEdit.Enabled = true;
            }

            if (formAction == FormAction.Edit)
            {
                FocusSidePanel(true);
                MANVTextEdit.Enabled =
                CMNDTextEdit.Enabled = false;
            }
            if (formAction == FormAction.None)
            {
                FocusSidePanel(false);

            }
            // Final condition require button to become enable 
            if (commandController.Redoable())
                btnRedo.Enabled = true;
            if (commandController.Undoable())
                btnUndo.Enabled = true;


            if (IsCurrentRowLock())
            {
                LockModifyRow();
            }


        }

        private bool IsCurrentRowLock()
        {
            bool hasFocusRow = nhanVienBds.Position != -1;
            bool isDeletedEmployee = ((DataRowView)nhanVienBds.Current)["TrangThaiXoa"].ToString() == "1";
            bool userGroupAllowModifyRow = Program.mGroup.ToUpper() != "NGANHANG";

            return (!hasFocusRow
                || isDeletedEmployee
                || !userGroupAllowModifyRow
                || formAction == FormAction.Add
                || formAction == FormAction.Edit);
        }

        private void SetDefaultButtonVisible()
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
            btnExit.Enabled = true;
            btnHuy.Enabled = false;
            btnReload.Enabled = true;
            btnChuyenCN.Enabled = true;

            btnLuu.Enabled = true;
            // Not allow to edit data directly user need to press Enter, Double click, ... as trigger
            sidePanel.Visible = false;
            gcNhanVien.Enabled = true;
        }
        private void EnableModifyForm(bool allowModify)
        {
            btnThem.Enabled =
            btnXoa.Enabled =
            btnSua.Enabled =
            btnUndo.Enabled =
            btnRedo.Enabled =
            btnChuyenCN.Enabled =
            sidePanel.Visible =
            btnLuu.Enabled = allowModify;
        }
        private void FocusSidePanel(bool isFocus)
        {
            sidePanel.Visible =
            sidePanel.Enabled = isFocus;
            if (isFocus)
            {
                DisableButtonOnSidePanelActive();
            }
            /* We should not EnableButtonOnSidePanel if SidePanel is not focus 
            *  because side panel focus => all feature button is diable (Always True) 
            *  side panel not focus != all feature button is enable (becaues not all case) 
            */
        }
        private void DisableButtonOnSidePanelActive()
        {
            btnHuy.Enabled =
            btnLuu.Enabled = true;

            btnXoa.Enabled =
            btnThem.Enabled =
            btnSua.Enabled =
            btnChuyenCN.Enabled =
            btnReload.Enabled =
            gcNhanVien.Enabled = false;
        }
        private void LockModifyRow()
        {
            btnXoa.Enabled = false;
            btnChuyenCN.Enabled = false;
            btnSua.Enabled = false;
        }
        // ----------------------------- Event ------------------------------
        private void formNhanVien_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            // Stop checking for foreign key constraint
            nhanVienDS1.EnforceConstraints = false;


            // Load data base on user login connection avoid using login and password in dataset 
            LoadNhanVien(Program.connstr);
            LoadCmbChiNhanh();

            // Init value for gener
            PHAIComboBox.Items.AddRange(new object[] {
            new KeyValue("Nam", "Name"),
            new KeyValue("Nữ", "Nữ")
            });
            PHAIComboBox.SelectedIndex = 0;
            PHAIComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SetFormState(FormAction.None);
        }


        /*
         * Trigger when user is change seleted branch program need to rebuild remote connection 
         * This connection build from a remote login with severname (base on selected branch) 
         * After build connection program need to fetch data to grid view again
         */
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
                // Fetch data when build connection success
                LoadNhanVien(Program.connstr);
            }

        }


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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenCreationSideBar();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenEditSideBar();
        }

        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HandleChuyenCN();
        }

        private void InputFields_KeyDown(object sender, KeyEventArgs e)
        {
            // Use for all text edit in form 
            if (e.KeyCode == Keys.Enter)
            {
                fBtnLuu.PerformClick();
            }

        }

        private void formNhanVien_KeyDown(object sender, KeyEventArgs e)
        // Use for all text edit field in creation new employee or edit employee.
        {
            if (e.KeyCode == Keys.Escape)
                if (btnHuy.Enabled)
                    HandleCancel();
            if (e.KeyCode == Keys.F5)
                if (btnReload.Enabled)
                    HandleReload();
            if (e.KeyCode == Keys.Delete)
                if (btnXoa.Enabled)
                    HandleDelete();
            if (e.Control)
            {
                if (e.KeyCode == Keys.S)
                    if (btnLuu.Enabled)
                        HandleSave();
                if (e.KeyCode == Keys.Z)
                    if (btnUndo.Enabled)
                        HandleUndo();
                if (e.KeyCode == Keys.Y)
                    if (btnRedo.Enabled)
                        HandleRedo();
            }
        }

        private void fBtnLuu_Click(object sender, EventArgs e)
        {
            btnLuu.PerformClick();
        }

        private void fBtnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.PerformClick();
        }

        private void gvNhanVien_DoubleClick(object sender, EventArgs e)
        {
            if (gcNhanVien.Enabled)
            {
                btnSua.PerformClick();
            }

        }
        private void gvNhanVien_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (IsCurrentRowLock())
            {
                LockModifyRow();
            }
        }

        private void PHAIComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPhai.Text = PHAIComboBox.Text;
        }

        private void gcNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua.PerformClick();
            }
        }
    }



}

