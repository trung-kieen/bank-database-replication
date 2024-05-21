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
            this.btnThongKeGD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKeTKMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKeKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnMoTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuiRut = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.loginManagerPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbGroupNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbGroupReport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.btnNhanVien,
            this.btnThongKeGD,
            this.btnThongKeTKMoi,
            this.btnThongKeKH,
            this.btnMoTK,
            this.btnGuiRut,
            this.btnChuyenTien});
            this.rbControl.LargeImages = this.imageCollection1;
            this.rbControl.Location = new System.Drawing.Point(0, 0);
            this.rbControl.Margin = new System.Windows.Forms.Padding(1);
            this.rbControl.MaxItemId = 17;
            this.rbControl.Name = "rbControl";
            this.rbControl.OptionsMenuMinWidth = 200;
            this.rbControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHeThong,
            this.rbQuanLy,
            this.rbNghiepVu,
            this.rbThongKe});
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
            // btnThongKeGD
            // 
            this.btnThongKeGD.Caption = "Giao dịch";
            this.btnThongKeGD.Id = 11;
            this.btnThongKeGD.ImageOptions.LargeImageIndex = 5;
            this.btnThongKeGD.Name = "btnThongKeGD";
            this.btnThongKeGD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKeGD_ItemClick);
            // 
            // btnThongKeTKMoi
            // 
            this.btnThongKeTKMoi.Caption = "Tài khoản mới mở";
            this.btnThongKeTKMoi.Id = 12;
            this.btnThongKeTKMoi.ImageOptions.LargeImageIndex = 6;
            this.btnThongKeTKMoi.Name = "btnThongKeTKMoi";
            this.btnThongKeTKMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKeTKMoi_ItemClick);
            // 
            // btnThongKeKH
            // 
            this.btnThongKeKH.Caption = "Khách hàng";
            this.btnThongKeKH.Id = 13;
            this.btnThongKeKH.ImageOptions.LargeImageIndex = 7;
            this.btnThongKeKH.Name = "btnThongKeKH";
            this.btnThongKeKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKeKH_ItemClick);
            // 
            // btnMoTK
            // 
            this.btnMoTK.Caption = "Mở tài khoản";
            this.btnMoTK.CausesValidation = true;
            this.btnMoTK.Id = 14;
            this.btnMoTK.ImageOptions.LargeImageIndex = 0;
            this.btnMoTK.Name = "btnMoTK";
            this.btnMoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoTK_ItemClick);
            // 
            // btnGuiRut
            // 
            this.btnGuiRut.Caption = "Gửi/Rút";
            this.btnGuiRut.Id = 15;
            this.btnGuiRut.ImageOptions.LargeImageIndex = 9;
            this.btnGuiRut.Name = "btnGuiRut";
            this.btnGuiRut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuiRut_ItemClick);
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Caption = "Chuyển tiền";
            this.btnChuyenTien.Id = 16;
            this.btnChuyenTien.ImageOptions.LargeImageIndex = 8;
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenTien_ItemClick);
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
            this.imageCollection1.Images.SetKeyName(5, "money_exchange.png");
            this.imageCollection1.Images.SetKeyName(6, "new_customer.png");
            this.imageCollection1.Images.SetKeyName(7, "customer_report.png");
            this.imageCollection1.Images.SetKeyName(8, "money_transfer.png");
            this.imageCollection1.Images.SetKeyName(9, "withdraw_deposit.png");
            // 
            // rbHeThong
            // 
            this.rbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.loginManagerPageGroup});
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
            this.rbGroupNghiepVu});
            this.rbNghiepVu.Name = "rbNghiepVu";
            this.rbNghiepVu.Text = "Nghiệp vụ";
            this.rbNghiepVu.Visible = false;
            // 
            // rbGroupNghiepVu
            // 
            this.rbGroupNghiepVu.ItemLinks.Add(this.btnMoTK);
            this.rbGroupNghiepVu.ItemLinks.Add(this.btnGuiRut);
            this.rbGroupNghiepVu.ItemLinks.Add(this.btnChuyenTien);
            this.rbGroupNghiepVu.Name = "rbGroupNghiepVu";
            // 
            // rbThongKe
            // 
            this.rbThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbGroupReport});
            this.rbThongKe.Name = "rbThongKe";
            this.rbThongKe.Text = "Thống kê";
            this.rbThongKe.Visible = false;
            // 
            // rbGroupReport
            // 
            this.rbGroupReport.ItemLinks.Add(this.btnThongKeGD);
            this.rbGroupReport.ItemLinks.Add(this.btnThongKeTKMoi);
            this.rbGroupReport.ItemLinks.Add(this.btnThongKeKH);
            this.rbGroupReport.Name = "rbGroupReport";
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbGroupNghiepVu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MANV;
        private System.Windows.Forms.ToolStripStatusLabel HOTEN;
        private System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbGroupReport;
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
        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageQuanLy;
        private DevExpress.XtraBars.BarButtonItem btnThongKeGD;
        private DevExpress.XtraBars.BarButtonItem btnThongKeTKMoi;
        private DevExpress.XtraBars.BarButtonItem btnThongKeKH;
        private DevExpress.XtraBars.BarButtonItem btnMoTK;
        private DevExpress.XtraBars.BarButtonItem btnGuiRut;
        private DevExpress.XtraBars.BarButtonItem btnChuyenTien;
    }
}

