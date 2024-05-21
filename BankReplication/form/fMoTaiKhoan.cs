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
using BankReplication.utils;
using static BankReplication.utils.Validate;


namespace BankReplication.form
{
    public partial class formMoTaiKhoan : SimpleForm
    {
        private Invoker commandController = new Invoker();
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

            if (formAction == FormAction.Add)
            {
                dataLayoutControl1.Enabled = true;
                gcKhachHang.Enabled = gcTaiKhoan.Enabled = false;
                soTKTxt.Enabled = true;
                ngayMoTKTxt.Enabled = false;

                btnHuy.Enabled = true;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;

                fBtnHuy.Visible = fBtnLuu.Visible = true;
            }
            else if (formAction == FormAction.Edit)
            {
                dataLayoutControl1.Enabled = true;
                gcKhachHang.Enabled = gcTaiKhoan.Enabled = false;
                ngayMoTKTxt.Enabled = true;
                soTKTxt.Enabled = false;

                btnHuy.Enabled = true;
                sidePanel.Visible = true;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;

                fBtnHuy.Visible = fBtnLuu.Visible = true;
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
        private void formMoTaiKhoan_Load(object sender, EventArgs e)
        {
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

        // TODO: 
        private bool InvalidNewAccount()
        {

            if (InvalidField(soTKTxt, "Số tài khoản", validateSoTK)) return true;
            if (InvalidField(soDuTxt, "Số dư", validateSoTien)) return true;
            return false;
        }
        // TODO:
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
                commandController.Execute(new EditCommand(taiKhoanBds, checkPointRowsData, dirtyRowsData, CommitChangeTK));
                SetFormState(FormAction.None);
                gvTaiKhoan.Focus();
            }
        }
        private void HandleRedo()
        {
            HandleCancel();
            commandController.Redo();
            //            HandleSave();
            SetFormState();
        }
        private void HandleUndo()
        {
            HandleCancel();
            commandController.Undo();
            //            HandleSave();
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


            current.Row["SOTK"] = soTKTxt.Text;
            current.Row["SODU"] = soDuTxt.Text;
            current.Row["MACN"] = maCNTxt.Text;
            current.Row["CMND"] = CMNDTxt.Text;
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
            if (gcTaiKhoan.Enabled)
                OpenEditSideBar();
        }
        private void gvTaiKhoan_LostFocus(object sender, EventArgs e)
        {
            SetFormState();
        }
        private void gvTaiKhoan_GotFocus(object sender, EventArgs e)
        {
            SetFormState();

        }
    }
}