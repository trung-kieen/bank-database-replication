namespace BankReplication.form
{
    partial class KhachHangForm
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
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel1;
            System.Windows.Forms.Label pHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangForm));
            this.khachHangBindingSource = new BankReplication.utils.BindingSourceExtends(this.components);
            this.DataSetAll = new BankReplication.NGANHANGDataSetAll();
            this.khachHangTableAdapter = new BankReplication.NGANHANGDataSetAllTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new BankReplication.NGANHANGDataSetAllTableAdapters.TableAdapterManager();
            this.barManagerKH = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedoKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatKH = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.chiNhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelDetailKH = new System.Windows.Forms.Panel();
            this.pHAIComboBox = new System.Windows.Forms.ComboBox();
            this.btnHuyDetailKH = new System.Windows.Forms.Button();
            this.btnLuuDetailKH = new System.Windows.Forms.Button();
            this.mACNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sODTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nGAYCAPDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chiNhanhTableAdapter = new BankReplication.NGANHANGDataSetAllTableAdapters.ChiNhanhTableAdapter();
            this.bindingSourceTaiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new BankReplication.NGANHANGDataSetAllTableAdapters.TaiKhoanTableAdapter();
            mACNLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel1 = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerKH)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).BeginInit();
            this.panelDetailKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mACNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(5, 6);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(74, 16);
            mACNLabel.TabIndex = 0;
            mACNLabel.Text = "Chi nhánh: ";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(30, 40);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(40, 13);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(30, 82);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(30, 124);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(30, 166);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(42, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Dịa chỉ:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(30, 252);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(56, 13);
            nGAYCAPLabel.TabIndex = 10;
            nGAYCAPLabel.Text = "Ngày cấp:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(30, 294);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(40, 13);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "Số ĐT:";
            // 
            // mACNLabel1
            // 
            mACNLabel1.AutoSize = true;
            mACNLabel1.Location = new System.Drawing.Point(30, 338);
            mACNLabel1.Name = "mACNLabel1";
            mACNLabel1.Size = new System.Drawing.Size(42, 13);
            mACNLabel1.TabIndex = 14;
            mACNLabel1.Text = "Mã CN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(30, 211);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(49, 13);
            pHAILabel.TabIndex = 16;
            pHAILabel.Text = "Giới tính:";
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.DataSetAll;
            // 
            // DataSetAll
            // 
            this.DataSetAll.DataSetName = "NGANHANGDataSetAll";
            this.DataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BankReplication.NGANHANGDataSetAllTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // barManagerKH
            // 
            this.barManagerKH.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManagerKH.DockControls.Add(this.barDockControlTop);
            this.barManagerKH.DockControls.Add(this.barDockControlBottom);
            this.barManagerKH.DockControls.Add(this.barDockControlLeft);
            this.barManagerKH.DockControls.Add(this.barDockControlRight);
            this.barManagerKH.Form = this;
            this.barManagerKH.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemKH,
            this.btnXoaKH,
            this.btnSuaKH,
            this.btnReloadKH,
            this.btnHuyKH,
            this.btnUndoKH,
            this.btnRedoKH,
            this.btnThoatKH,
            this.btnLuuKH});
            this.barManagerKH.MainMenu = this.bar2;
            this.barManagerKH.MaxItemId = 9;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemKH),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaKH),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSuaKH),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuuKH),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReloadKH),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuyKH),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndoKH),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedoKH),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoatKH)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Caption = "Thêm";
            this.btnThemKH.Enabled = false;
            this.btnThemKH.Id = 0;
            this.btnThemKH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemKH.ImageOptions.SvgImage")));
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThemKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLuuKH_ItemClick);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Caption = "Xóa";
            this.btnXoaKH.Enabled = false;
            this.btnXoaKH.Id = 1;
            this.btnXoaKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKH.ImageOptions.Image")));
            this.btnXoaKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaKH.ImageOptions.LargeImage")));
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoaKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Caption = "Sửa";
            this.btnSuaKH.Enabled = false;
            this.btnSuaKH.Id = 2;
            this.btnSuaKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKH.ImageOptions.Image")));
            this.btnSuaKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaKH.ImageOptions.LargeImage")));
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSuaKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItemSua_ItemClick);
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.Caption = "Lưu";
            this.btnLuuKH.Enabled = false;
            this.btnLuuKH.Id = 8;
            this.btnLuuKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuKH.ImageOptions.Image")));
            this.btnLuuKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuuKH.ImageOptions.LargeImage")));
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuuKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuKH_ItemClick);
            // 
            // btnReloadKH
            // 
            this.btnReloadKH.Caption = "Làm mới";
            this.btnReloadKH.Enabled = false;
            this.btnReloadKH.Id = 3;
            this.btnReloadKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadKH.ImageOptions.Image")));
            this.btnReloadKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReloadKH.ImageOptions.LargeImage")));
            this.btnReloadKH.Name = "btnReloadKH";
            this.btnReloadKH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReloadKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnReload_ItemClick);
            // 
            // btnHuyKH
            // 
            this.btnHuyKH.Caption = "Hủy";
            this.btnHuyKH.Enabled = false;
            this.btnHuyKH.Id = 4;
            this.btnHuyKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyKH.ImageOptions.Image")));
            this.btnHuyKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyKH.ImageOptions.LargeImage")));
            this.btnHuyKH.Name = "btnHuyKH";
            this.btnHuyKH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuyKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyKH_ItemClick);
            // 
            // btnUndoKH
            // 
            this.btnUndoKH.Caption = "Undo";
            this.btnUndoKH.Enabled = false;
            this.btnUndoKH.Id = 5;
            this.btnUndoKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoKH.ImageOptions.Image")));
            this.btnUndoKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndoKH.ImageOptions.LargeImage")));
            this.btnUndoKH.Name = "btnUndoKH";
            this.btnUndoKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoKH_ItemClick);
            // 
            // btnRedoKH
            // 
            this.btnRedoKH.Caption = "Redo";
            this.btnRedoKH.Enabled = false;
            this.btnRedoKH.Id = 6;
            this.btnRedoKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRedoKH.ImageOptions.Image")));
            this.btnRedoKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRedoKH.ImageOptions.LargeImage")));
            this.btnRedoKH.Name = "btnRedoKH";
            this.btnRedoKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRedoKH_ItemClick);
            // 
            // btnThoatKH
            // 
            this.btnThoatKH.Caption = "Thoát";
            this.btnThoatKH.Id = 7;
            this.btnThoatKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatKH.ImageOptions.Image")));
            this.btnThoatKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatKH.ImageOptions.LargeImage")));
            this.btnThoatKH.Name = "btnThoatKH";
            this.btnThoatKH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoatKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatKH_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerKH;
            this.barDockControlTop.Size = new System.Drawing.Size(928, 24);
            this.barDockControlTop.Click += new System.EventHandler(this.barDockControlTop_Click);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 495);
            this.barDockControlBottom.Manager = this.barManagerKH;
            this.barDockControlBottom.Size = new System.Drawing.Size(928, 0);
            this.barDockControlBottom.Click += new System.EventHandler(this.barDockControlBottom_Click);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManagerKH;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 471);
            this.barDockControlLeft.Click += new System.EventHandler(this.barDockControlLeft_Click);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(928, 24);
            this.barDockControlRight.Manager = this.barManagerKH;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 471);
            this.barDockControlRight.Click += new System.EventHandler(this.barDockControlRight_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(mACNLabel);
            this.panel3.Controls.Add(this.cmbChiNhanh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 30);
            this.panel3.TabIndex = 6;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiNhanhBindingSource, "MACN", true));
            this.cmbChiNhanh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(93, 3);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(182, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // chiNhanhBindingSource
            // 
            this.chiNhanhBindingSource.DataMember = "ChiNhanh";
            this.chiNhanhBindingSource.DataSource = this.DataSetAll;
            this.chiNhanhBindingSource.CurrentChanged += new System.EventHandler(this.chiNhanhBindingSource_CurrentChanged);
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.khachHangBindingSource;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachHangGridControl.Location = new System.Drawing.Point(0, 0);
            this.khachHangGridControl.MainView = this.gridViewKhachHang;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(674, 441);
            this.khachHangGridControl.TabIndex = 1;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKhachHang});
            // 
            // gridViewKhachHang
            // 
            this.gridViewKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridViewKhachHang.GridControl = this.khachHangGridControl;
            this.gridViewKhachHang.Name = "gridViewKhachHang";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            // 
            // panelDetailKH
            // 
            this.panelDetailKH.AutoScroll = true;
            this.panelDetailKH.Controls.Add(this.pHAIComboBox);
            this.panelDetailKH.Controls.Add(pHAILabel);
            this.panelDetailKH.Controls.Add(this.btnHuyDetailKH);
            this.panelDetailKH.Controls.Add(this.btnLuuDetailKH);
            this.panelDetailKH.Controls.Add(mACNLabel1);
            this.panelDetailKH.Controls.Add(this.mACNTextEdit);
            this.panelDetailKH.Controls.Add(sODTLabel);
            this.panelDetailKH.Controls.Add(this.sODTTextEdit);
            this.panelDetailKH.Controls.Add(nGAYCAPLabel);
            this.panelDetailKH.Controls.Add(this.nGAYCAPDateEdit);
            this.panelDetailKH.Controls.Add(dIACHILabel);
            this.panelDetailKH.Controls.Add(this.dIACHITextEdit);
            this.panelDetailKH.Controls.Add(tENLabel);
            this.panelDetailKH.Controls.Add(this.tENTextEdit);
            this.panelDetailKH.Controls.Add(hOLabel);
            this.panelDetailKH.Controls.Add(this.hOTextEdit);
            this.panelDetailKH.Controls.Add(cMNDLabel);
            this.panelDetailKH.Controls.Add(this.cMNDTextEdit);
            this.panelDetailKH.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDetailKH.Location = new System.Drawing.Point(674, 0);
            this.panelDetailKH.Name = "panelDetailKH";
            this.panelDetailKH.Size = new System.Drawing.Size(254, 441);
            this.panelDetailKH.TabIndex = 0;
            // 
            // pHAIComboBox
            // 
            this.pHAIComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "PHAI", true));
            this.pHAIComboBox.DisplayMember = "Text";
            this.pHAIComboBox.FormattingEnabled = true;
            this.pHAIComboBox.Location = new System.Drawing.Point(87, 208);
            this.pHAIComboBox.Name = "pHAIComboBox";
            this.pHAIComboBox.Size = new System.Drawing.Size(126, 21);
            this.pHAIComboBox.TabIndex = 18;
            this.pHAIComboBox.ValueMember = "Value";
            // 
            // btnHuyDetailKH
            // 
            this.btnHuyDetailKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDetailKH.Location = new System.Drawing.Point(122, 377);
            this.btnHuyDetailKH.Name = "btnHuyDetailKH";
            this.btnHuyDetailKH.Size = new System.Drawing.Size(99, 29);
            this.btnHuyDetailKH.TabIndex = 16;
            this.btnHuyDetailKH.Text = "Hủy";
            this.btnHuyDetailKH.UseVisualStyleBackColor = true;
            this.btnHuyDetailKH.Click += new System.EventHandler(this.btnHuyDetailKH_Click);
            // 
            // btnLuuDetailKH
            // 
            this.btnLuuDetailKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuuDetailKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDetailKH.ForeColor = System.Drawing.Color.White;
            this.btnLuuDetailKH.Location = new System.Drawing.Point(17, 377);
            this.btnLuuDetailKH.Name = "btnLuuDetailKH";
            this.btnLuuDetailKH.Size = new System.Drawing.Size(99, 29);
            this.btnLuuDetailKH.TabIndex = 16;
            this.btnLuuDetailKH.Text = "Lưu";
            this.btnLuuDetailKH.UseVisualStyleBackColor = false;
            this.btnLuuDetailKH.Click += new System.EventHandler(this.btnLuuDetailKH_Click);
            // 
            // mACNTextEdit
            // 
            this.mACNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "MACN", true));
            this.mACNTextEdit.Enabled = false;
            this.mACNTextEdit.Location = new System.Drawing.Point(87, 335);
            this.mACNTextEdit.MenuManager = this.barManagerKH;
            this.mACNTextEdit.Name = "mACNTextEdit";
            this.mACNTextEdit.Size = new System.Drawing.Size(126, 20);
            this.mACNTextEdit.TabIndex = 15;
            // 
            // sODTTextEdit
            // 
            this.sODTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "SODT", true));
            this.sODTTextEdit.Location = new System.Drawing.Point(87, 291);
            this.sODTTextEdit.MenuManager = this.barManagerKH;
            this.sODTTextEdit.Name = "sODTTextEdit";
            this.sODTTextEdit.Size = new System.Drawing.Size(126, 20);
            this.sODTTextEdit.TabIndex = 13;
            // 
            // nGAYCAPDateEdit
            // 
            this.nGAYCAPDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "NGAYCAP", true));
            this.nGAYCAPDateEdit.EditValue = null;
            this.nGAYCAPDateEdit.Location = new System.Drawing.Point(87, 249);
            this.nGAYCAPDateEdit.MenuManager = this.barManagerKH;
            this.nGAYCAPDateEdit.Name = "nGAYCAPDateEdit";
            this.nGAYCAPDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYCAPDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYCAPDateEdit.Size = new System.Drawing.Size(126, 20);
            this.nGAYCAPDateEdit.TabIndex = 11;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(87, 163);
            this.dIACHITextEdit.MenuManager = this.barManagerKH;
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(126, 20);
            this.dIACHITextEdit.TabIndex = 7;
            // 
            // tENTextEdit
            // 
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "TEN", true));
            this.tENTextEdit.Location = new System.Drawing.Point(87, 121);
            this.tENTextEdit.MenuManager = this.barManagerKH;
            this.tENTextEdit.Name = "tENTextEdit";
            this.tENTextEdit.Size = new System.Drawing.Size(126, 20);
            this.tENTextEdit.TabIndex = 5;
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "HO", true));
            this.hOTextEdit.Location = new System.Drawing.Point(87, 79);
            this.hOTextEdit.MenuManager = this.barManagerKH;
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Size = new System.Drawing.Size(126, 20);
            this.hOTextEdit.TabIndex = 3;
            // 
            // cMNDTextEdit
            // 
            this.cMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "CMND", true));
            this.cMNDTextEdit.Location = new System.Drawing.Point(87, 37);
            this.cMNDTextEdit.MenuManager = this.barManagerKH;
            this.cMNDTextEdit.Name = "cMNDTextEdit";
            this.cMNDTextEdit.Size = new System.Drawing.Size(126, 20);
            this.cMNDTextEdit.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.khachHangGridControl);
            this.panel2.Controls.Add(this.panelDetailKH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 441);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceTaiKhoan
            // 
            this.bindingSourceTaiKhoan.DataMember = "TaiKhoan";
            this.bindingSourceTaiKhoan.DataSource = this.DataSetAll;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // KhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(928, 495);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "KhachHangForm";
            this.Text = "KhachHangForm";
            this.Load += new System.EventHandler(this.KhachHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerKH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).EndInit();
            this.panelDetailKH.ResumeLayout(false);
            this.panelDetailKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mACNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NGANHANGDataSetAll DataSetAll;
        private BankReplication.utils.BindingSourceExtends khachHangBindingSource;
        private NGANHANGDataSetAllTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private NGANHANGDataSetAllTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManagerKH;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemKH;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.Panel panelDetailKH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource chiNhanhBindingSource;
        private NGANHANGDataSetAllTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraBars.BarButtonItem btnXoaKH;
        private DevExpress.XtraBars.BarButtonItem btnSuaKH;
        private DevExpress.XtraBars.BarButtonItem btnReloadKH;
        private DevExpress.XtraBars.BarButtonItem btnHuyKH;
        private DevExpress.XtraBars.BarButtonItem btnUndoKH;
        private DevExpress.XtraBars.BarButtonItem btnRedoKH;
        private DevExpress.XtraBars.BarButtonItem btnThoatKH;
        private DevExpress.XtraEditors.TextEdit mACNTextEdit;
        private DevExpress.XtraEditors.TextEdit sODTTextEdit;
        private DevExpress.XtraEditors.DateEdit nGAYCAPDateEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit tENTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private DevExpress.XtraEditors.TextEdit cMNDTextEdit;
        private System.Windows.Forms.Button btnLuuDetailKH;
        private System.Windows.Forms.Button btnHuyDetailKH;
        private DevExpress.XtraBars.BarButtonItem btnLuuKH;
        private System.Windows.Forms.ComboBox pHAIComboBox;
        private System.Windows.Forms.BindingSource bindingSourceTaiKhoan;
        private NGANHANGDataSetAllTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
    }
}