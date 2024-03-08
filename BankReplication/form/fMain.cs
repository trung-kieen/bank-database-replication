using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankReplication
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
            DisplayRiborn(true);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }


        private Form CheckExist(Type formType)
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
        
        private void DisplayRiborn(bool isDisplay)
        {
            rbBaoCao.Visible = isDisplay;
            rbChuyenKhoan.Visible = isDisplay;
            rbControl.Visible = isDisplay;
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
            
        }
    }
}
