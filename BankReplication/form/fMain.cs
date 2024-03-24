using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankReplication.form;

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


        private Form CheckExist(Type formType)
        /// <summary>
        /// Use for get form object orginize in formMain property MdiChildren
        /// <para>typeof(formClassName)</para>
        /// Return: class instance match this type or null if there no mdiForm match this type
        /// </summary>
        {
            foreach (Form childForm in this.MdiChildren)
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
            rbGiaoDich.Visible = displayState;
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
            rbControl.SelectPage(this.rbHeThong);

        }

    }
}
