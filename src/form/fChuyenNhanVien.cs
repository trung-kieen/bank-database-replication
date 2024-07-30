using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankReplication.utils;
using DevExpress.XtraEditors;
// Author: trung-kieen

/*
 * Form perform list of branch to user to select which branch employee need to transfer to
 * Form should call from fNhanVien.cs
 */
namespace BankReplication.form
{
    public partial class formChuyenNhanVien : SimpleForm
    {
        private DataTable otherBranches;
        public String manv_moi;
        public String macn_moi;
        public String remote_connstr;
        private String cmnd;
        public bool submit = false;
        public formChuyenNhanVien(String cmnd)
        {
            this.cmnd = cmnd;
            InitializeComponent();
        }

        private void formChuyenNhanVien_Load(object sender, EventArgs e)
        {
            try
            {

                // Copy mapping of other branches from global static mapping
                DataTable dspm = (DataTable)Program.bds_dspm.DataSource;
                otherBranches = new DataTable();
                otherBranches = (dspm).Clone();
                if (dspm.Rows.Count == 1)
                {
                    throw new Exception("Không tìm thấy chi nhánh khác để chuyển nhân viên tới");
                   
                }
                for (int i = 0; i < dspm.Rows.Count; i++)
                {
                    // Copy all branch - servername except branch of employee
                    if (i != Program.mChiNhanh)
                    {
                        otherBranches.ImportRow(dspm.Rows[i]);
                    }
                }


                this.cmbChiNhanh.DataSource = otherBranches;
                this.cmbChiNhanh.DisplayMember = "TENCN";
                this.cmbChiNhanh.ValueMember = "TENSERVER";

                // Default select first branch in list
                this.cmbChiNhanh.SelectedIndex = 0;

            }
            catch(Exception ex)
            {
                Msg.Error("Lỗi tải chi nhánh khác\n" + ex.Message);
                this.Close();
            }
            LoadChiNhanh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Employee with same persion id match => No need to validate
            if (txtMaNVMoi.Enabled == false)
            {
                HandleSubmit();
                return;
            }

            if (txtMaNVMoi.Text.Trim() == "")
            {
                Msg.Warm("Mã nhân viên mới không được để trống");
                txtMaNVMoi.Focus();
                return;
            }
            if (Program.KetNoi() == Database.Connection.Fail) return;
            try
            {
                int existCode = Int32.Parse(Program.ExecSqlScalar("EXEC SP_TimNhanVien '" + txtMaNVMoi.Text + "'"));
                if (existCode == Database.CheckExist.NotFound)
                {
                    HandleSubmit();
                }
                else
                {
                    Msg.Warm("Mã nhân viên mới bị trùng với nhân viên khác");
                    txtMaNVMoi.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                Msg.Error("Lỗi khi kiểm tra mã nhân viên\n" + ex.Message);
                SetEmployeeId();
            }


        }
        private void HandleSubmit()
        {
            submit = true;
            manv_moi = txtMaNVMoi.Text;
            this.Close();
        }

        private void LoadChiNhanh()
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            // Get data with remote login HTKN
            Program.mlogin = Program.remotelogin;
            Program.password = Program.remotepassword;
            if (Program.KetNoi() == Database.Connection.Fail)
            {
                Msg.Error("Lỗi kết nối về chi nhánh mới");
            }
            else
            {

                remote_connstr = Program.connstr;
                macn_moi = Program.ExecSqlScalar("SELECT TOP 1 MACN FROM NGANHANG.dbo.ChiNhanh");
                SetEmployeeId();
            }
        }
        private void SetEmployeeId()
        {
                // NOTE: this command execute on remote server to selected server
                manv_moi = Program.ExecSqlScalar("SELECT TOP 1 MANV FROM NGANHANG.dbo.NhanVien WHERE CMND = '" + cmnd + "'");
                if (manv_moi != null) goto LockId;
                manv_moi = Program.GetNewEmployeeID();
                if (manv_moi != null) goto LockId;

                if (txtMaNVMoi.Text == "")
                    txtMaNVMoi.Enabled = true; 

                LockId:
                    txtMaNVMoi.Enabled = false;
                    txtMaNVMoi.Text = manv_moi;
                    return;

        }
        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChiNhanh();
        }

        private void txtMaNVMoi_KeyDown(object sender, KeyEventArgs e)
        { 

            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }

        }
    }
}