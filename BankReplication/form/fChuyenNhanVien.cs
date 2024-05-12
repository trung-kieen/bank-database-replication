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

namespace BankReplication.form
{
    public partial class formChuyenNhanVien : SimpleForm
    {
        private DataTable otherBrarch;
        public String manv_moi;
        public String macn_moi;
        public String remote_connstr;
        private String cmnd;
        public bool submit = false ;
        public formChuyenNhanVien(String cmnd)
        {
            this.cmnd = cmnd;
            InitializeComponent();
        }

        private void formChuyenNhanVien_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dspm = (DataTable)Program.bds_dspm.DataSource;
                otherBrarch = new DataTable();
                otherBrarch = (dspm).Clone();
                if (dspm.Rows.Count == 1)
                {
                    throw new Exception("Không tìm thấy chi nhánh khác để chuyển nhân viên tới");
                }
                for(int i = 0; i < dspm.Rows.Count; i++)
                {
                // Lay danh sach phan manh khac chi nhanh hien tai 
                    if(i!= Program.mChiNhanh)
                    {
                        otherBrarch.ImportRow(dspm.Rows[i]);
                    }
                }


                this.cmbChiNhanh.DataSource = otherBrarch; 
                this.cmbChiNhanh.DisplayMember = "TENCN";
                this.cmbChiNhanh.ValueMember = "TENSERVER";
                this.cmbChiNhanh.SelectedIndex = 0;
                LoadChiNhanh();

            }
            catch 
            {
//                Msg.Error("Lỗi tải chi nhánh khác\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Employee with same persion id match => No need to validate
            if (txtMaNVMoi.Enabled == false)
            {
                HandleSubmit();
                return;
            }

            if(txtMaNVMoi.Text.Trim() == "")
            {
                Msg.Warm("Mã nhân viên mới không được để trống");
                txtMaNVMoi.Focus();
                return;
            }
            if (Program.KetNoi() == Database.Connection.Fail) return;
            try
            {
                int existCode = Int32.Parse(Program.ExecSqlScalar("EXEC SP_TimNhanVien '" + txtMaNVMoi.Text + "'"));
                if(existCode  == Database.CheckExist.NotFound)
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
            catch(Exception ex)
            {
                Msg.Error("Lỗi khi kiểm tra mã nhân viên\n" + ex.Message);
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
                macn_moi = Program.ExecSqlScalar("SELECT MACN FROM NGANHANG.dbo.NhanVien");
                // NOTE: this command execute on remote server to selected server
                manv_moi = Program.ExecSqlScalar("SELECT MANV FROM NGANHANG.dbo.NhanVien WHERE CMND = '" + cmnd + "'");
                if (manv_moi == null)
                {
                    txtMaNVMoi.Enabled = true;  
                    txtMaNVMoi.Text = "";
                }
                else
                {
                    txtMaNVMoi.Enabled = false;  
                    txtMaNVMoi.Text = manv_moi;

                }
                // Load user input
                 
            }


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