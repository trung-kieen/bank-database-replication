namespace BankReplication
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.rbControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.loginManagerPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.addAccountRbPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbMoTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbGuiRut = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.rbChuyenKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbKhachHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rbControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbControl
            // 
            this.rbControl.AllowMdiChildButtons = false;
            this.rbControl.ExpandCollapseItem.Id = 0;
            this.rbControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbControl.ExpandCollapseItem,
            this.rbControl.SearchEditItem,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnAddAccount,
            this.btnKhachHang,
            this.btnNhanVien});
            this.rbControl.LargeImages = this.imageCollection1;
            this.rbControl.Location = new System.Drawing.Point(0, 0);
            this.rbControl.Margin = new System.Windows.Forms.Padding(1);
            this.rbControl.MaxItemId = 11;
            this.rbControl.Name = "rbControl";
            this.rbControl.OptionsMenuMinWidth = 200;
            this.rbControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHeThong,
            this.rbQuanLy,
            this.rbNghiepVu,
            this.rbBaoCao});
            this.rbControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.rbControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.rbControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.rbControl.ShowToolbarCustomizeItem = false;
            this.rbControl.Size = new System.Drawing.Size(1312, 231);
            this.rbControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 4;
            this.btnDangNhap.ImageOptions.LargeImageIndex = 1;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 5;
            this.btnDangXuat.ImageOptions.LargeImageIndex = 2;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Caption = "Tạo tài khoản";
            this.btnAddAccount.Id = 7;
            this.btnAddAccount.ImageOptions.LargeImageIndex = 0;
            this.btnAddAccount.Name = "btnAddAccount";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách hàng";
            this.btnKhachHang.Id = 8;
            this.btnKhachHang.ImageOptions.LargeImageIndex = 4;
            this.btnKhachHang.Name = "btnKhachHang";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 9;
            this.btnNhanVien.ImageOptions.LargeImageIndex = 3;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(40, 40);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "add_account.png");
            this.imageCollection1.Images.SetKeyName(1, "login.png");
            this.imageCollection1.Images.SetKeyName(2, "logout.png");
            this.imageCollection1.Images.SetKeyName(3, "employee.png");
            this.imageCollection1.Images.SetKeyName(4, "customer.png");
            // 
            // rbHeThong
            // 
            this.rbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.loginManagerPageGroup,
            this.addAccountRbPageGroup});
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ thống";
            this.rbHeThong.Visible = false;
            // 
            // loginManagerPageGroup
            // 
            this.loginManagerPageGroup.ItemLinks.Add(this.btnDangNhap);
            this.loginManagerPageGroup.ItemLinks.Add(this.btnDangXuat, true);
            this.loginManagerPageGroup.Name = "loginManagerPageGroup";
            // 
            // addAccountRbPageGroup
            // 
            this.addAccountRbPageGroup.ImageOptions.Image = global::BankReplication.Properties.Resources.add_account;
            this.addAccountRbPageGroup.ItemLinks.Add(this.btnAddAccount);
            this.addAccountRbPageGroup.Name = "addAccountRbPageGroup";
            // 
            // rbQuanLy
            // 
            this.rbQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPageQuanLy});
            this.rbQuanLy.Name = "rbQuanLy";
            this.rbQuanLy.Text = "Quản lý";
            this.rbQuanLy.Visible = false;
            // 
            // rbPageQuanLy
            // 
            this.rbPageQuanLy.ItemLinks.Add(this.btnNhanVien);
            this.rbPageQuanLy.ItemLinks.Add(this.btnKhachHang);
            this.rbPageQuanLy.Name = "rbPageQuanLy";
            // 
            // rbNghiepVu
            // 
            this.rbNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbMoTaiKhoan,
            this.rbGuiRut});
            this.rbNghiepVu.Name = "rbNghiepVu";
            this.rbNghiepVu.Text = "Nghiệp vụ";
            this.rbNghiepVu.Visible = false;
            // 
            // rbMoTaiKhoan
            // 
            this.rbMoTaiKhoan.Name = "rbMoTaiKhoan";
            this.rbMoTaiKhoan.Text = "Mở tài khoản";
            // 
            // rbGuiRut
            // 
            this.rbGuiRut.Name = "rbGuiRut";
            this.rbGuiRut.Text = "Gửi rút";
            // 
            // rbBaoCao
            // 
            this.rbBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbBaoCao.Name = "rbBaoCao";
            this.rbBaoCao.Text = "Báo cáo";
            this.rbBaoCao.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 812);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1312, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(69, 25);
            this.MANV.Text = "MÃ NV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(75, 25);
            this.HOTEN.Text = "HỌ TÊN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(68, 25);
            this.NHOM.Text = "NHÓM";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = null;
            // 
            // rbChuyenKhoan
            // 
            this.rbChuyenKhoan.Name = "rbChuyenKhoan";
            this.rbChuyenKhoan.Text = "Chuyển khoản";
            // 
            // rbKhachHang
            // 
            this.rbKhachHang.Name = "rbKhachHang";
            this.rbKhachHang.Text = "Khách Hàng";
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Text = "Nhân viên";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.rbControl;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // formMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 842);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rbControl);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formMain";
            this.Ribbon = this.rbControl;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbMoTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbGuiRut;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MANV;
        private System.Windows.Forms.ToolStripStatusLabel HOTEN;
        private System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup loginManagerPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbChuyenKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnAddAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup addAccountRbPageGroup;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageQuanLy;
    }
}

