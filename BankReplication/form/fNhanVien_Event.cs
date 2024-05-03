using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankReplication.utils;
using System.Windows.Forms;

namespace BankReplication.form
{
    public partial class formNhanVien : SimpleForm
    {
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
                if(btnLuu.Enabled)
                    HandleSave();
            }

        }

        private void formNhanVien_KeyDown(object sender, KeyEventArgs e)
        // Use for all text edit field in creation new employee or edit employee.
        {
            if (e.KeyCode == Keys.Escape)
                if(btnHuy.Enabled)
                    HandleCancel();
            if (e.KeyCode == Keys.F5)
                if(btnReload.Enabled)
                    HandleReload();
            if (e.KeyCode == Keys.Delete)
                if(btnXoa.Enabled)
                    HandleDelete();
            if (e.Control)
            {
                if (e.KeyCode == Keys.S)
                    if(btnLuu.Enabled)
                        HandleSave();
                if (e.KeyCode == Keys.Z)
                    if(btnUndo.Enabled)
                        HandleUndo();
                if (e.KeyCode == Keys.Y)
                    if(btnRedo.Enabled)
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
    }
}
