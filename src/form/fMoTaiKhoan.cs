﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BankReplication.utils;
using DevExpress.XtraBars;
using static BankReplication.utils.Validate;
// Author: trung-kieen


/*
 * Form display user provide some feature for create user bank account
 * For provide update UI application need to change FormAction and display button base on each state
 * To provide undo and redo action any action work with data will perform on a Command (see Command.cs)
 * Each action change data: add, edit, delete,... will write change directly to database 
 * not base on default strategy of GridView
 * Same with fNhanVien.cs but provide a sub view to show account tie with user
 * When create new bank account we will base on current select user infromation to add foreign key (CMND)
 */

namespace BankReplication.form
{
    public partial class formMoTaiKhoan : SimpleForm
    {
        private Invoker commandController = new Invoker();
        private Invoker khachHangRowController = new Invoker();
        private object[] checkPointRowsData;
        private String macn;
        private int topRowIndex;
        private FormAction formAction;
        private int focusedRowHandle;
        public formMoTaiKhoan()
        {
            InitializeComponent();
        }
        private void SavePosition()
        {

            topRowIndex = gvTaiKhoan.TopRowIndex;
            focusedRowHandle = gvTaiKhoan.FocusedRowHandle;

        }
        private void RevertLastPosition()
        {
            // Revert position from SavePosition();
            gvTaiKhoan.FocusedRowHandle = focusedRowHandle;
            gvTaiKhoan.TopRowIndex = topRowIndex;

            gcTaiKhoan.Enabled = gcKhachHang.Enabled = true;
            gvTaiKhoan.Focus();
        }

        private void SetFormState(FormAction state)
        {
            formAction = state;
            SetFormState();
        }
        private void SetFormState()
        {
            SetDefaultButtonVisible();

            bool userAllowModifyForm = Program.mGroup.ToUpper() == "NGANHANG";
            EnableModifyForm(userAllowModifyForm);


            if (formAction == FormAction.Add)
            {
                dataLayoutControl1.Enabled = true;
                gcKhachHang.Enabled = gcTaiKhoan.Enabled = false;
                soTKTxt.Enabled = true;
                ngayMoTKTxt.Enabled = false;
                DisableButtonOnSidePanelActive();

            }
            else if (formAction == FormAction.Edit)
            {
                dataLayoutControl1.Enabled = true;
                gcKhachHang.Enabled = gcTaiKhoan.Enabled = false;
                ngayMoTKTxt.Enabled = true;
                soTKTxt.Enabled = false;

                DisableButtonOnSidePanelActive();
            }
            else
            {
                dataLayoutControl1.Enabled = false;
                gcKhachHang.Enabled = gcTaiKhoan.Enabled = true;
            }
            if (taiKhoanBds.Position == -1 || taiKhoanBds.Count == 0)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            if (commandController.Redoable())
                btnRedo.Enabled = true;
            if (commandController.Undoable())
                btnUndo.Enabled = true;

        }

        private void DisableButtonOnSidePanelActive()
        {
                btnHuy.Enabled = true;
                btnXoa.Enabled = false;
                btnReload.Enabled = false;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;

                fBtnHuy.Visible = fBtnLuu.Visible = true;
        }
        private void EnableModifyForm(bool allowModify)
        {


                dataLayoutControl1.Enabled =
                btnThem.Enabled = 
                btnXoa.Enabled = 
                btnSua.Enabled =
                btnUndo.Enabled = 
                btnRedo.Enabled =
                btnLuu.Enabled = false;
                return;

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
            btnLuu.Enabled = true;
            fBtnHuy.Visible = fBtnLuu.Visible = false;

        }

        private void ResetSideBar()
        {
            soTKTxt.Focus();
        }
        public void OpenCreationSideBar()
        // Mở form thêm dữ liệu chưa lưu lại
        {
            SavePosition();
            SetFormState(FormAction.Add);
            taiKhoanBds.AddNew();
            ResetSideBar();
            InitNewRowData();
        }
        public void OpenEditSideBar()
        {
            
            checkPointRowsData = ModelMapper.RowViewToRowList((DataRowView)taiKhoanBds.Current);
            SavePosition();
            SetFormState(FormAction.Edit);
            ResetSideBar();
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
            if (!General.SwitchBranchOnAddNewAccount)
            {
                cmbChiNhanh.Dispose();
                lblChiNhanh.Dispose();
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
                LoadTaiKhoan(Program.connstr);
            }

        }

        private void formMoTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadCmbChiNhanh();
            this.KeyPreview = true;
            // Stop checking for foreign key constraint
            moTKDS.EnforceConstraints = false;


            this.gDGuiRutTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gDChuyenTienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gDGuiRutTableAdapter.Fill(this.moTKDS.GDGuiRut);
            this.gDChuyenTienTableAdapter.Fill(this.moTKDS.GDChuyenTien);
            khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.moTKDS.KhachHang);
            LoadTaiKhoan(Program.connstr);
            SetFormState(FormAction.None);

        }
        public void HandleRefresh()
        {
            SavePosition();
            LoadTaiKhoan(Program.connstr);
            RevertLastPosition();

        }
        public void HandleDelete()
        {
            if (formAction != FormAction.None) return;
            if (taiKhoanBds.Position < 0)
                return;
            SavePosition();
            if (gDGuiRutBindingSource.Count > 0)
            {
                Msg.Warm("Không thể xóa tài khoản này vì đã lập giao dịch gửi rút");
                return;
            }
            if (gDChuyenTienBindingSource.Count > 0 || gDChuyenTienBindingSource1.Count > 0)
            {
                Msg.Warm("Không thể xóa tài khoản này vì đã lập giao dịch chuyển tiền");
                return;
            }


            if (Msg.InforConfirm("Bạn có thực sự muốn xóa tài khoản này?") == DialogResult.OK)
            {
                try
                {
                    khachHangRowController.Execute(new PositionCommand(khachHangBds));
                    commandController.Execute(new DeleteCommand(taiKhoanBds, (DataRowView)taiKhoanBds.Current, HandleRefresh, CommitChangeTK));
                    SetFormState(FormAction.None);
                }
                catch (Exception ex)
                {
                    Msg.Error("Lỗi không thể xóa nhân viên\n" + ex.Message);
                    LoadTaiKhoan(Program.connstr);
                    RevertLastPosition();
                }
            }
        }
        private void HandleSave()
        {

            if (formAction == FormAction.None)
            {
                CommitChangeTK();
                HandleReload();
            }
            if (formAction == FormAction.Add)
                HandleAdd();
            if (formAction == FormAction.Edit)
                HandleEdit();

        }
        private void HandleCancel()
        {
            if (formAction == FormAction.Add)
            {
                taiKhoanBds.RemoveCurrent();
                SetFormState(FormAction.None);
                RevertLastPosition();

            }
            if (formAction == FormAction.Edit)
            {

                DataRowView current = (DataRowView)taiKhoanBds.Current;
                SetFormState(FormAction.None);
                RevertLastPosition();
            }
        }

        private bool InvalidNewAccount()
        {
            if (InvalidField(soTKTxt, "Số tài khoản", validateSoTK)) return true;
            if (InvalidField(soDuTxt, "Số dư", validateSoTien)) return true;
            if (InvalidNewAccountNum(soTKTxt)) return true;
            return false;
        }

        private Boolean InvalidNewAccountNum(DevExpress.XtraEditors.TextEdit field)
        {
            if (Program.KetNoi() == Database.Connection.Fail)
            {
                Msg.Error("Lỗi kết nối với với cơ sở dữ liệu");
                return true;
            }

            if (Program.IsAccountExist(field.Text))
            {
                Msg.Warm("Số tài khoản đã tồn tại");
                field.Focus();
                return true;
            }
            return false;
        }



        private bool InvalidEditAcount()
        {
            if (InvalidField(soTKTxt, "Số tài khoản", validateSoTK)) return true;
            if (InvalidField(soDuTxt, "Số dư", validateSoTien)) return true;
            return false;
        }
        public void HandleAdd()
        {
            if (!InvalidNewAccount())
            {
                SaveViewRowToBindingSource();
                khachHangRowController.Execute(new PositionCommand(khachHangBds));
                commandController.Execute(new AddCommand(taiKhoanBds, (DataRowView)taiKhoanBds.Current, HandleRefresh, CommitChangeTK));
                SetFormState(FormAction.None);
                gvTaiKhoan.Focus();
            }
        }
        private void HandleEdit()
        {
            if (!InvalidEditAcount())
            {

                SaveViewRowToBindingSource();
                taiKhoanBds.EndEdit();
                object[] dirtyRowsData = ModelMapper.RowViewToRowList((DataRowView)taiKhoanBds.Current);
                khachHangRowController.Execute(new PositionCommand(khachHangBds));
                commandController.Execute(new EditCommand(taiKhoanBds, checkPointRowsData, dirtyRowsData, CommitChangeTK));
                SetFormState(FormAction.None);
                gvTaiKhoan.Focus();
            }
        }
        private void HandleRedo()
        {
            HandleCancel();
            khachHangRowController.Redo();
            commandController.Redo();
            SetFormState();
        }
        private void HandleUndo()
        {
            HandleCancel();
            khachHangRowController.Undo();
            commandController.Undo();
            SetFormState();
        }
        public void HandleReload()
        {
            HandleCancel();
            gcTaiKhoan.Enabled = false;
            HandleRefresh();
            gcTaiKhoan.Enabled = true;
            gvTaiKhoan.Focus();

        }
        public void InitNewRowData()
        {

            if (macn == null)
                macn = Program.LayMaCN();
            if (macn == null)
            {
                Msg.Error("Lỗi tải mã chi nhánh");
                return;
            }
            CMNDTxt.Text = ((DataRowView)taiKhoanBds.Current)["CMND"].ToString();
            if (macn.ToString().Trim() == "") return;
            maCNTxt.Text = macn;
            ngayMoTKTxt.EditValue = DateTime.Now;
        }
        public void SaveViewRowToBindingSource()
        {
            DataRowView current = (DataRowView)taiKhoanBds.Current;
            // Check if misleading when save data -> save data in this way

            // Tricky to flush EditValue actualy change, avoid dirty change on form
            fBtnLuu.Focus();


            try
            {
            current.Row["SOTK"] = soTKTxt.Text;
            current.Row["SODU"] = soDuTxt.Text;
            current.Row["MACN"] = maCNTxt.Text;
            current.Row["CMND"] = CMNDTxt.Text;
            }catch (Exception ex ) {
                Msg.Error(ex.Message);
            }
            try
            {
                current.Row["NGAYMOTK"] =  DateTime.ParseExact(ngayMoTKTxt.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                current.Row["NGAYMOTK"] = ngayMoTKTxt.Text;
            }

        }

        private void LoadTaiKhoan(String connstr)
        {
            try
            {
                taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.moTKDS.TaiKhoan);
            }
            catch (Exception ex)
            {

                Msg.Error("Lỗi tải về dữ liệu\n" + ex.Message, "");
            }

        }
        private void CommitChangeTK()
        {
            try
            {
                taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                //                moTKDS.AcceptChanges();
                taiKhoanTableAdapter.Update(moTKDS.TaiKhoan);
            }
            catch (Exception ex)
            {
                Msg.Error("Ghi dữ liệu không thành công\n" + ex.Message);
                HandleRefresh();
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


        private void InputFields_KeyDown(object sender, KeyEventArgs e)
        {
            // Use for all text edit in form 
            if (e.KeyCode == Keys.Enter)
            {
                if (btnLuu.Enabled)
                    HandleSave();
            }


        }



        private void formMoTaiKhoan_KeyDown(object sender, KeyEventArgs e)
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

        private void gvKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (Program.mGroup.ToUpper() == "NGANHANG") return;
            if (taiKhoanBds.Count > 0)
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;

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

        private void gvKhachHang_DoubleClick(object sender, EventArgs e)
        {
            if (gcKhachHang.Enabled)
            {
                gvTaiKhoan.Focus();
            }

        }
        private void gvTaiKhoan_DoubleClick(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }
        private void gvTaiKhoan_LostFocus(object sender, EventArgs e)
        {
            SetFormState();
        }
        private void gvTaiKhoan_GotFocus(object sender, EventArgs e)
        {
            SetFormState();

        }

        private void officeNavigationBar1_Click(object sender, EventArgs e)
        {

        }
        private void gcTaiKhoan_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

        private void gcKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gcTaiKhoan.Focus();


        }
        

        private void gcTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
               btnSua.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
                gcKhachHang.Focus();
        }

    }
}