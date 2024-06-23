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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using BankReplication.utils;
using static BankReplication.utils.Validate;
using System.Security.Cryptography;
enum FormActionKH { None, Add, Edit };

namespace BankReplication.form
{
    public partial class KhachHangForm : DevExpress.XtraEditors.XtraForm
    {
        private Invoker commandController = new Invoker();
        private String macn;
        private String CMND;
        //private String manv;
        private int topRowIndex;
        private int focusedRowHandle;
        private FormActionKH formAction;
        private object[] checkPointRowsData;
        public KhachHangForm()
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
            mACNTextEdit.Text = macn;

            
            pHAIComboBox.SelectedIndex = 0;
        }
        public void SaveViewRowToBindingSource()
        {
            
            //Gán dữ liệu từ text đến gridControl view
            DataRowView current = (DataRowView)khachHangBindingSource.Current;
            current.Row["HO"] = hOTextEdit.Text;
            current.Row["TEN"] = tENTextEdit.Text;
            current.Row["DIACHI"] = dIACHITextEdit.Text;
            current.Row["CMND"] = cMNDTextEdit.Text;
            current.Row["PHAI"] = pHAIComboBox.Text.ToString();
            current.Row["SODT"] = sODTTextEdit.Text;
            current.Row["MACN"] = mACNTextEdit.Text;
        }

        private Boolean InvalidNewCustomer()
        {
            if (InvalidField(cMNDTextEdit, "Số chứng minh nhân dân", validateCMND)){
                return true;
            }
            if (InvalidField(hOTextEdit, "Họ", validateHo)) return true;
            if (InvalidField(tENTextEdit, "Tên", validateTen)) return true;

            // Track not allow to duplicate because unique key
            //if (InvalidField(cMNDTextEdit, "Số chứng minh nhân dân", validateCMND)) return true;
            if (InvalidField(dIACHITextEdit, "Địa chỉ", validateDiaChi)) return true;
            if (InvalidField(pHAIComboBox, "Giới tính", validatePhai)) return true;

            // SDT Allow null!!! change db contraint
            if (InvalidField(sODTTextEdit, "Số điện thoại", validateSDT)) return true;
            if (InvalidField(mACNTextEdit, "Mã chi nhánh", validateMACN)) return true;
            
            if (InvalidDuplicateCMND()) return true;
            return false;
        }

        private Boolean InvalidEditCustomer()
        {

            if (InvalidField(cMNDTextEdit, "Số chứng minh nhân dân", validateCMND)) return true;
            if (InvalidField(hOTextEdit, "Họ", validateHo)) return true;
            if (InvalidField(tENTextEdit, "Tên", validateTen)) return true;

            if (InvalidField(dIACHITextEdit, "Địa chỉ", validateDiaChi)) return true;
            if (InvalidField(pHAIComboBox, "Giới tính", validatePhai)) return true;

            if (InvalidField(sODTTextEdit, "Số điện thoại", validateSDT)) return true;
            if (InvalidField(mACNTextEdit, "Mã chi nhánh", validateMACN)) return true;

            
            if (!cMNDTextEdit.OldEditValue.ToString().Trim().Equals(cMNDTextEdit.EditValue.ToString().Trim()))
            {
                if (InvalidDuplicateCMND()) return true;
            }
            return false;
        }

        private Boolean InvalidDuplicateCMND()
        {
            int ExistsCode = Int32.Parse(Program.ExecSqlScalar("EXEC SP_TimCMNDKhachHang '" + cMNDTextEdit.Text.Trim() + "'"));
            if (ExistsCode == Database.CheckExist.FoundSameSite)
            {
                Msg.Warm("Số CMND không được trùng với khách hàng cùng chi nhánh", "Dữ liệu nhập không hợp lệ");
                cMNDTextEdit.Focus();
                return true;
            }
            else if (ExistsCode == Database.CheckExist.FoundOtherSite)
            {
                Msg.Warm("Số CMND không được trùng với khách hàng khác chi nhánh khác", "Dữ liệu nhập không hợp lệ");
                cMNDTextEdit.Focus();
                return true;
            }
            
            return false;
        }

        // ===============================> Form Data <================================

        private void LoadKhachHang(String connstr)
        {
            try
            {
                khachHangTableAdapter.Connection.ConnectionString = connstr;
                khachHangTableAdapter.Fill(DataSetAll.KhachHang);

            }
            catch (Exception ex)
            {
                Msg.Error("Lỗi tải về dữ liệu\n" + ex.Message, "");
            }

        }
        private void CommitChangeKhachHang()
        {
            try
            {
                khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                khachHangTableAdapter.Update(DataSetAll.KhachHang);
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


        public void HandleDelete()
        {
            if (formAction != FormActionKH.None) return;
            if (khachHangBindingSource.Position < 0)
                return;
            SavePosition();

            if (Msg.InforConfirm("Bạn có thực sự muốn xóa nhân viên này?") == DialogResult.OK)
            {
                try
                {
                    commandController.Execute(new DeleteCommand(khachHangBindingSource, (DataRowView)khachHangBindingSource.Current, HandleRefresh, CommitChangeKhachHang));
                    SetFormState(FormActionKH.None);
                }
                catch (Exception ex)
                {
                    Msg.Error("Lỗi không thể xóa nhân viên có tài khoản!\n" + ex.Message);
                    LoadKhachHang(Program.connstr);
                    RevertLastPosition();
                }
            }
        }


        public void HandleReload()
        {
            HandleCancel();
            khachHangGridControl.Enabled = false;
            HandleRefresh();
            khachHangGridControl.Enabled = true;
            khachHangGridControl.Focus();

        }
        public void HandleRefresh()
        {
            SavePositionByCMND();
            LoadKhachHang(Program.connstr);
            RevertLastPositionByCMND();
        }

        public void HandleAdd()
        {
            if (!InvalidNewCustomer())
            {
                SaveViewRowToBindingSource();
                khachHangBindingSource.EndEdit();
                //Lưu stack các bước thực thi
                commandController.Execute(new AddCommand(khachHangBindingSource, (DataRowView)khachHangBindingSource.Current, HandleRefresh, CommitChangeKhachHang));
                SetFormState(FormActionKH.None);
                gridViewKhachHang.Focus();
            }
        }
        private void HandleCancel()
        {
            if (formAction == FormActionKH.Add)
            {
                khachHangBindingSource.RemoveCurrent();
                SetFormState(FormActionKH.None);
                RevertLastPosition();
            }
            if (formAction == FormActionKH.Edit)
            {

                DataRowView current = (DataRowView)khachHangBindingSource.Current;
                khachHangBindingSource.CancelEdit();
                SetFormState(FormActionKH.None);
                RevertLastPosition();
            }
        }
        private void HandleEdit()
        {
            if (!InvalidEditCustomer())
            {
                pHAIComboBox.EndUpdate();
                SaveViewRowToBindingSource();
                object[] dirtyRowsData = ModelMapper.RowViewToRowList((DataRowView)khachHangBindingSource.Current);
                commandController.Execute(new EditCommand(khachHangBindingSource, checkPointRowsData, dirtyRowsData, CommitChangeKhachHang));
                SetFormState(FormActionKH.None);
                gridViewKhachHang.Focus();
            }
        }

        private void HandleUndo()
        {
            HandleCancel();
            commandController.Undo();
            //            HandleSave();
            SetFormState();
        }
        private void HandleRedo()
        {
            HandleCancel();
            commandController.Redo();
            //            HandleSave();
            SetFormState();
        }
        private void HandleSave()
        {

            if (formAction == FormActionKH.None)
            {
                CommitChangeKhachHang();
                HandleReload();
            }
            if (formAction == FormActionKH.Add)
                HandleAdd();
            if (formAction == FormActionKH.Edit)
                HandleEdit();

        }

        // ================================================> UI Perform <========================================================
        public void OpenEditSideBar()
        {
            if (Program.mGroup.ToUpper() != "CHINHANH") return;
            DataRowView r = (DataRowView)khachHangBindingSource.Current;
            pHAIComboBox.SelectedIndex = pHAIComboBox.FindStringExact(r.Row["PHAI"].ToString());
            checkPointRowsData = ModelMapper.RowViewToRowList((DataRowView)khachHangBindingSource.Current);
            SavePosition();
            SetFormState(FormActionKH.Edit);
            ResetSideBar();
        }
        private void ResetSideBar()
        {
            if (formAction == FormActionKH.Edit)
            {
                hOTextEdit.Focus();
            }
            else if (formAction == FormActionKH.Add)
            {
                cMNDTextEdit.Focus();
            }

        }


        private void SavePosition()
        {

            topRowIndex = gridViewKhachHang.TopRowIndex;
            focusedRowHandle = gridViewKhachHang.FocusedRowHandle;

        }

        private void SavePositionByCMND()
        {
            CMND = ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["CMND"].ToString(); ;
            topRowIndex = gridViewKhachHang.TopRowIndex;
        }
        private void RevertLastPositionByCMND()
        {
            // Revert position from SavePositionByMa();
            khachHangBindingSource.Position = khachHangBindingSource.Find("CMND", CMND);
            gridViewKhachHang.TopRowIndex = topRowIndex;
        }
        private void RevertLastPosition()
        {
            // Revert position from SavePosition();
            gridViewKhachHang.FocusedRowHandle = focusedRowHandle;
            gridViewKhachHang.TopRowIndex = topRowIndex;

            khachHangGridControl.Enabled = true;
            gridViewKhachHang.Focus();
        }
        public void OpenCreationSideBar()
        // Mở form thêm dữ liệu chưa lưu lại
        {
            SavePosition();
            SetFormState(FormActionKH.Add);
            khachHangBindingSource.AddNew();
            ResetSideBar();
            InitNewRowData();
        }

        private void SetFormState(FormActionKH state)
        {
            formAction = state;
            SetFormState();
        }
        private void SetFormState()
        {
            // Reset state 
            btnThemKH.Enabled = true;
            btnXoaKH.Enabled = true;
            btnSuaKH.Enabled = true;
            btnUndoKH.Enabled = false;
            btnRedoKH.Enabled = false;
            btnThoatKH.Enabled = true;
            btnHuyKH.Enabled = false;
            btnReloadKH.Enabled = true;


            btnLuuKH.Enabled = false;
            panelDetailKH.Enabled = false;
            panelDetailKH.Visible = false;
            khachHangGridControl.Enabled = true;

            if (Program.mGroup.ToUpper() == "NGANHANG")
            {
                btnThemKH.Enabled = false;
                btnXoaKH.Enabled = false;
                btnSuaKH.Enabled = false;
                btnUndoKH.Enabled = false;
                btnRedoKH.Enabled = false;
                btnLuuKH.Enabled = false;
            }
            else
            {

                if (formAction == FormActionKH.Add)
                {
                    
                    panelDetailKH.Visible = true;
                    panelDetailKH.Enabled = true;
                    khachHangGridControl.Enabled = false;
                    cMNDTextEdit.Enabled = true;

                    btnHuyKH.Enabled = true;
                    btnXoaKH.Enabled = false;
                    btnLuuKH.Enabled = true;
                    btnReloadKH.Enabled = false;
                    btnThemKH.Enabled = false;
                    btnSuaKH.Enabled = false;

                }

                if (formAction == FormActionKH.Edit)
                {
                    panelDetailKH.Visible = true;
                    panelDetailKH.Enabled = true;
                    khachHangGridControl.Enabled = false;
                    
                    cMNDTextEdit.Enabled = true;

                    btnHuyKH.Enabled = true;
                    btnXoaKH.Enabled = false;
                    btnLuuKH.Enabled = true;
                    btnThemKH.Enabled = false;
                    btnSuaKH.Enabled = false;

                }
                if (formAction == FormActionKH.None)
                {
                    panelDetailKH.Visible = true;
                    panelDetailKH.Enabled = false; //editDang
                    btnHuyKH.Enabled = false;
                    btnLuuKH.Enabled = false;
                    
                }
                // Final condition require button to become enable 
                if (khachHangBindingSource.Position == -1)
                {
                    btnXoaKH.Enabled = false;
                    btnSuaKH.Enabled = false;
                }
                if (commandController.Redoable())
                    btnRedoKH.Enabled = true;
                if (commandController.Undoable())
                    btnUndoKH.Enabled = true;
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
            if (Program.KetNoi() == Database.Connection.Fail)
            {
                Msg.Error("Lỗi kết nối về chi nhánh mới");
            }
            else
            {
                // Load data
                LoadKhachHang(Program.connstr);
            }
        }

        //////==================EndEdit=================================================

        //private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.khachHangBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.DataSetAll);

        //}

        //private void khachHangBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.khachHangBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.DataSetAll);

        //}

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetAll.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.DataSetAll.TaiKhoan);
            // TODO: This line of code loads data into the 'DataSetAll.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.DataSetAll.TaiKhoan);
            this.KeyPreview = true;
            // Stop checking for foreign key constraint
            DataSetAll.EnforceConstraints = false;


            // Load data base on user login connection avoid using login and password in dataset 
            LoadKhachHang(Program.connstr);
            LoadCmbChiNhanh();

            pHAIComboBox.Items.AddRange(new object[] {
            new KeyValue("Nam", "Nam"),
            new KeyValue("Nữ", "Nữ")
            });
            
            pHAIComboBox.SelectedIndex = 0;
            pHAIComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            SetFormState(FormActionKH.None);

        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlBottom_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlLeft_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlRight_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chiNhanhBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HandleDelete();
        }

        private void btnHuyKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HandleCancel();
        }

        private void btnUndoKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HandleUndo();
        }

        private void btnRedoKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HandleRedo();
        }

        private void btnLuuKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HandleSave();
        }

        private void btnThoatKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnHuyDetailKH_Click(object sender, EventArgs e)
        {
            btnHuyKH.PerformClick();
        }

        private void btnLuuDetailKH_Click(object sender, EventArgs e)
        {
            btnLuuKH.PerformClick();
        }

        private void barBtnItemSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenEditSideBar();
        }

        private void barBtnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HandleReload();
        }

      

        private void barBtnLuuKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenCreationSideBar();
        }
    }
}