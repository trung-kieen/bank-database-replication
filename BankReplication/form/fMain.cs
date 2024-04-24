using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankReplication.form;
using DevExpress.XtraReports.UI;
using BankReplication.report;

namespace BankReplication
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
            CustomLoad();

        }

        
        
        private void CustomLoad()
        {
            StartPosition = FormStartPosition.CenterScreen;
            btnDangNhap.PerformClick();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }


        public static void SetEnableOfButton(Form frm, Boolean Active)
        {

            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }

        private Form CheckExist(Type formType)
        /// <summary>
        /// Use for get form object orginize in formMain property MdiChildren
        /// <para>typeof(formClassName)</para>
        /// Return: class instance match this type or null if there no mdiForm match this type
        /// </summary>
        {
            foreach (var childForm in this.MdiChildren)
            {
                if (childForm.GetType() == formType)
                {
                    return childForm;
                }
            }
            return null;

        }


        
        private void RbVisible(bool displayState)
        {
            rbBaoCao.Visible = displayState;
            rbChuyenKhoan.Visible = displayState;
            rbHeThong.Visible = displayState;
            rbNghiepVu.Visible = displayState;
            rbQuanLy.Visible = displayState;
        }



        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fDangNhap = CheckExist(typeof(formDangNhap));
            if(fDangNhap == null)
            {
                fDangNhap= new formDangNhap();
                fDangNhap.MdiParent = this;
                fDangNhap.Show();
            }
            else{
                fDangNhap.Activate();
            }


            // Reset element when user login
            this.MANV.Text = "MÃ NV";
            this.HOTEN.Text = "HỌ TÊN";
            this.NHOM.Text = "NHÓM";
            RbVisible(false);

        }



        public void HienThiMenu()
        {
            MANV.Text = "MÃ NV: " + Program.username;
            HOTEN.Text = "HỌ TÊN: " + Program.mHoTen;
            NHOM.Text = "NHÓM: " + Program.mGroup;
            RbVisible(true);
            
            // Hide dev express button
            btnDangNhap.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            rbControl.SelectPage(this.rbHeThong);
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fNhanVien = CheckExist(typeof(formNhanVien));
            if(fNhanVien == null)
            {
                fNhanVien= new formNhanVien();
                fNhanVien.MdiParent = this;
                fNhanVien.Show();
            }
            else{
                fNhanVien.Activate();
            }

        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // Delete old working tab mdi 
            foreach(var tab in this.MdiChildren)
            {
                tab.Close();

            }
            Program.frmChinh.btnDangNhap.PerformClick();
        }

        private void btnThongKeGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport thongKeTaiKhoan = new rptGiaoDich();
            IReportPrintTool print = new ReportPrintTool(thongKeTaiKhoan);
            print.ShowPreviewDialog();
        }
    }
}
