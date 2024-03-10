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
            AfterLoad();
        }
        
        private void AfterLoad()
        {
            StartPosition = FormStartPosition.CenterScreen;
            btnDangNhap.PerformClick();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RbVisible(false);
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
        
        private void RbVisible(bool isDisplay)
        {
            rbBaoCao.Visible = isDisplay;
            rbChuyenKhoan.Visible = isDisplay;
            rbHeThong.Visible = isDisplay;
            rbQuanLy.Visible = isDisplay;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void rbControl_Click(object sender, EventArgs e)
        {

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


        }
    }
}
