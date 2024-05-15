using System.Windows.Forms;
using BankReplication.utils;
namespace BankReplication.form
{
    partial class formNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label pHAILabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNhanVien));
            this.sidePanel = new DevExpress.XtraEditors.PanelControl();
            this.fBtnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.fBtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.PHAIComboBox = new System.Windows.Forms.ComboBox();
            this.nhanVienBds = new BankReplication.utils.BindingSourceExtends(this.components);
            this.nhanVienDS1 = new BankReplication.NhanVienDS();
            this.trangThaiXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.MACNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SODTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MANVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanVienTableAdapter1 = new BankReplication.NhanVienDSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new BankReplication.NhanVienDSTableAdapters.TableAdapterManager();
            this.gD_CHUYENTIENTableAdapter = new BankReplication.NhanVienDSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.gD_GOIRUTTableAdapter = new BankReplication.NhanVienDSTableAdapters.GD_GOIRUTTableAdapter();
            this.gD_CHUYENTIENBds = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTBds = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolBoxPanel = new DevExpress.XtraEditors.PanelControl();
            this.controlPanel = new DevExpress.XtraEditors.PanelControl();
            this.toolBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemChiTietDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnMENU = new DevExpress.XtraBars.BarSubItem();
            this.btnCheDoDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheDoChiTietDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            pHAILabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MACNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SODTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MANVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBoxPanel)).BeginInit();
            this.toolBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(16, 80);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(109, 19);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(87, 129);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(35, 19);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(81, 175);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(42, 19);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(66, 222);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(59, 19);
            cMNDLabel.TabIndex = 6;
            cMNDLabel.Text = "CMND:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(62, 274);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(63, 19);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(17, 368);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(108, 19);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "Số điện thoại:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(16, 416);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(109, 19);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "Mã chi nhánh:";
            // 
            // pHAILabel1
            // 
            pHAILabel1.AutoSize = true;
            pHAILabel1.Location = new System.Drawing.Point(79, 320);
            pHAILabel1.Name = "pHAILabel1";
            pHAILabel1.Size = new System.Drawing.Size(45, 19);
            pHAILabel1.TabIndex = 18;
            pHAILabel1.Text = "Phái:";
            // 
            // sidePanel
            // 
            this.sidePanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.sidePanel.Appearance.Options.UseBackColor = true;
            this.sidePanel.Controls.Add(this.fBtnHuy);
            this.sidePanel.Controls.Add(this.fBtnLuu);
            this.sidePanel.Controls.Add(pHAILabel1);
            this.sidePanel.Controls.Add(this.PHAIComboBox);
            this.sidePanel.Controls.Add(this.trangThaiXoaCheckBox);
            this.sidePanel.Controls.Add(mACNLabel);
            this.sidePanel.Controls.Add(this.MACNTextEdit);
            this.sidePanel.Controls.Add(sODTLabel);
            this.sidePanel.Controls.Add(this.SODTTextEdit);
            this.sidePanel.Controls.Add(dIACHILabel);
            this.sidePanel.Controls.Add(this.DIACHITextEdit);
            this.sidePanel.Controls.Add(cMNDLabel);
            this.sidePanel.Controls.Add(this.CMNDTextEdit);
            this.sidePanel.Controls.Add(tENLabel);
            this.sidePanel.Controls.Add(this.TENTextEdit);
            this.sidePanel.Controls.Add(hOLabel);
            this.sidePanel.Controls.Add(this.HOTextEdit);
            this.sidePanel.Controls.Add(mANVLabel);
            this.sidePanel.Controls.Add(this.MANVTextEdit);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(2, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(389, 929);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.Visible = false;
            // 
            // fBtnHuy
            // 
            this.fBtnHuy.Location = new System.Drawing.Point(216, 529);
            this.fBtnHuy.Name = "fBtnHuy";
            this.fBtnHuy.Size = new System.Drawing.Size(112, 48);
            this.fBtnHuy.TabIndex = 20;
            this.fBtnHuy.Text = "Hủy";
            this.fBtnHuy.Click += new System.EventHandler(this.fBtnHuy_Click);
            // 
            // fBtnLuu
            // 
            this.fBtnLuu.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.fBtnLuu.Appearance.Options.UseBackColor = true;
            this.fBtnLuu.Location = new System.Drawing.Point(70, 529);
            this.fBtnLuu.Name = "fBtnLuu";
            this.fBtnLuu.Size = new System.Drawing.Size(112, 48);
            this.fBtnLuu.TabIndex = 19;
            this.fBtnLuu.Text = "Lưu";
            this.fBtnLuu.Click += new System.EventHandler(this.fBtnLuu_Click);
            // 
            // PHAIComboBox
            // 
            this.PHAIComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBds, "PHAI", true));
            this.PHAIComboBox.DisplayMember = "Name";
            this.PHAIComboBox.FormattingEnabled = true;
            this.PHAIComboBox.Location = new System.Drawing.Point(132, 317);
            this.PHAIComboBox.Name = "PHAIComboBox";
            this.PHAIComboBox.Size = new System.Drawing.Size(150, 27);
            this.PHAIComboBox.TabIndex = 10;
            this.PHAIComboBox.ValueMember = "Name";
            // 
            // nhanVienBds
            // 
            this.nhanVienBds.DataMember = "NhanVien";
            this.nhanVienBds.DataSource = this.nhanVienDS1;
            this.nhanVienBds.Sort = "";
            // 
            // nhanVienDS1
            // 
            this.nhanVienDS1.DataSetName = "NhanVienDS";
            this.nhanVienDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trangThaiXoaCheckBox
            // 
            this.trangThaiXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nhanVienBds, "TrangThaiXoa", true));
            this.trangThaiXoaCheckBox.Enabled = false;
            this.trangThaiXoaCheckBox.Location = new System.Drawing.Point(92, 468);
            this.trangThaiXoaCheckBox.Name = "trangThaiXoaCheckBox";
            this.trangThaiXoaCheckBox.Size = new System.Drawing.Size(171, 34);
            this.trangThaiXoaCheckBox.TabIndex = 17;
            this.trangThaiXoaCheckBox.Text = "TRANG THAI XOA";
            this.trangThaiXoaCheckBox.UseVisualStyleBackColor = true;
            this.trangThaiXoaCheckBox.Visible = false;
            // 
            // MACNTextEdit
            // 
            this.MACNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "MACN", true));
            this.MACNTextEdit.Enabled = false;
            this.MACNTextEdit.Location = new System.Drawing.Point(132, 412);
            this.MACNTextEdit.Name = "MACNTextEdit";
            this.MACNTextEdit.Size = new System.Drawing.Size(150, 28);
            this.MACNTextEdit.TabIndex = 15;
            this.MACNTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // SODTTextEdit
            // 
            this.SODTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "SODT", true));
            this.SODTTextEdit.Location = new System.Drawing.Point(132, 364);
            this.SODTTextEdit.Name = "SODTTextEdit";
            this.SODTTextEdit.Properties.MaxLength = 15;
            this.SODTTextEdit.Size = new System.Drawing.Size(150, 28);
            this.SODTTextEdit.TabIndex = 11;
            this.SODTTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // DIACHITextEdit
            // 
            this.DIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "DIACHI", true));
            this.DIACHITextEdit.Location = new System.Drawing.Point(132, 270);
            this.DIACHITextEdit.Name = "DIACHITextEdit";
            this.DIACHITextEdit.Properties.MaxLength = 100;
            this.DIACHITextEdit.Size = new System.Drawing.Size(150, 28);
            this.DIACHITextEdit.TabIndex = 9;
            this.DIACHITextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // CMNDTextEdit
            // 
            this.CMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "CMND", true));
            this.CMNDTextEdit.Location = new System.Drawing.Point(132, 219);
            this.CMNDTextEdit.Name = "CMNDTextEdit";
            this.CMNDTextEdit.Properties.MaxLength = 10;
            this.CMNDTextEdit.Size = new System.Drawing.Size(150, 28);
            this.CMNDTextEdit.TabIndex = 7;
            this.CMNDTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // TENTextEdit
            // 
            this.TENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "TEN", true));
            this.TENTextEdit.Location = new System.Drawing.Point(132, 172);
            this.TENTextEdit.Name = "TENTextEdit";
            this.TENTextEdit.Properties.MaxLength = 10;
            this.TENTextEdit.Size = new System.Drawing.Size(150, 28);
            this.TENTextEdit.TabIndex = 5;
            this.TENTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // HOTextEdit
            // 
            this.HOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "HO", true));
            this.HOTextEdit.Location = new System.Drawing.Point(132, 126);
            this.HOTextEdit.Name = "HOTextEdit";
            this.HOTextEdit.Properties.MaxLength = 50;
            this.HOTextEdit.Size = new System.Drawing.Size(150, 28);
            this.HOTextEdit.TabIndex = 3;
            this.HOTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // MANVTextEdit
            // 
            this.MANVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "MANV", true));
            this.MANVTextEdit.Location = new System.Drawing.Point(132, 76);
            this.MANVTextEdit.Name = "MANVTextEdit";
            this.MANVTextEdit.Properties.MaxLength = 10;
            this.MANVTextEdit.Size = new System.Drawing.Size(150, 28);
            this.MANVTextEdit.TabIndex = 1;
            this.MANVTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.nhanVienBds;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhanVien.Location = new System.Drawing.Point(2, 2);
            this.gcNhanVien.MainView = this.gvNhanVien;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1914, 929);
            this.gcNhanVien.TabIndex = 2;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien});
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colCMND,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gvNhanVien.DetailHeight = 349;
            this.gvNhanVien.FixedLineWidth = 1;
            this.gvNhanVien.GridControl = this.gcNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.OptionsBehavior.Editable = false;
            this.gvNhanVien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNhanVien_FocusedRowChanged);
            this.gvNhanVien.DoubleClick += new System.EventHandler(this.gvNhanVien_DoubleClick);
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 30;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 112;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 30;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 3;
            this.colCMND.Width = 112;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 112;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 30;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 5;
            this.colPHAI.Width = 112;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 30;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 112;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 30;
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.ReadOnly = true;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 112;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 30;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 8;
            this.colTrangThaiXoa.Width = 112;
            // 
            // nhanVienTableAdapter1
            // 
            this.nhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.gD_CHUYENTIENTableAdapter;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter1;
            this.tableAdapterManager.UpdateOrder = BankReplication.NhanVienDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // gD_CHUYENTIENBds
            // 
            this.gD_CHUYENTIENBds.DataMember = "FK_GD_CHUYENTIEN_NhanVien";
            this.gD_CHUYENTIENBds.DataSource = this.nhanVienBds;
            // 
            // gD_GOIRUTBds
            // 
            this.gD_GOIRUTBds.DataMember = "FK_GD_GOIRUT_NhanVien";
            this.gD_GOIRUTBds.DataSource = this.nhanVienBds;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sidePanel);
            this.panelControl1.Controls.Add(this.gcNhanVien);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 80);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1918, 933);
            this.panelControl1.TabIndex = 3;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.cmbChiNhanh);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1914, 42);
            this.panelControl3.TabIndex = 2;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(120, 8);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(269, 27);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chi Nhánh";
            // 
            // toolBoxPanel
            // 
            this.toolBoxPanel.Controls.Add(this.panelControl3);
            this.toolBoxPanel.Controls.Add(this.controlPanel);
            this.toolBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBoxPanel.Location = new System.Drawing.Point(0, 34);
            this.toolBoxPanel.Name = "toolBoxPanel";
            this.toolBoxPanel.Size = new System.Drawing.Size(1918, 46);
            this.toolBoxPanel.TabIndex = 1;
            // 
            // controlPanel
            // 
            this.controlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(2, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1914, 42);
            this.controlPanel.TabIndex = 3;
            // 
            // toolBarManager
            // 
            this.toolBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.toolBar,
            this.bar3});
            this.toolBarManager.DockControls.Add(this.barDockControlTop);
            this.toolBarManager.DockControls.Add(this.barDockControlBottom);
            this.toolBarManager.DockControls.Add(this.barDockControlLeft);
            this.toolBarManager.DockControls.Add(this.barDockControlRight);
            this.toolBarManager.Form = this;
            this.toolBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnLuu,
            this.btnUndo,
            this.btnReload,
            this.btnCHUYENCHINHANH,
            this.btnExit,
            this.btnThemChiTietDonDatHang,
            this.btnMENU,
            this.btnCheDoDonDatHang,
            this.btnCheDoChiTietDonDatHang,
            this.btnSua,
            this.btnRedo,
            this.btnHuy,
            this.btnChuyenCN});
            this.toolBarManager.MainMenu = this.toolBar;
            this.toolBarManager.MaxItemId = 15;
            this.toolBarManager.StatusBar = this.bar3;
            // 
            // toolBar
            // 
            this.toolBar.BarName = "Main menu";
            this.toolBar.DockCol = 0;
            this.toolBar.DockRow = 0;
            this.toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.toolBar.FloatLocation = new System.Drawing.Point(70, 255);
            this.toolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChuyenCN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedo),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.toolBar.OptionsBar.MultiLine = true;
            this.toolBar.OptionsBar.UseWholeRow = true;
            this.toolBar.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Enabled = false;
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 0);
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Enabled = false;
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 0);
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnChuyenCN
            // 
            this.btnChuyenCN.Caption = "Chuyển chi nhánh";
            this.btnChuyenCN.Id = 14;
            this.btnChuyenCN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChuyenCN.ImageOptions.SvgImage")));
            this.btnChuyenCN.Name = "btnChuyenCN";
            this.btnChuyenCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenCN_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 11;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Enabled = false;
            this.btnLuu.Id = 2;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 0);
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Làm Mới";
            this.btnReload.Enabled = false;
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 13;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Redo";
            this.btnRedo.Id = 12;
            this.btnRedo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRedo.ImageOptions.SvgImage")));
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRedo_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 7;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.toolBarManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.barDockControlTop.Size = new System.Drawing.Size(1918, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1013);
            this.barDockControlBottom.Manager = this.toolBarManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1918, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.toolBarManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 979);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1918, 34);
            this.barDockControlRight.Manager = this.toolBarManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 979);
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 5;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            // 
            // btnThemChiTietDonDatHang
            // 
            this.btnThemChiTietDonDatHang.Caption = "Thêm Chi Tiết Đơn Đặt Hàng";
            this.btnThemChiTietDonDatHang.Id = 7;
            this.btnThemChiTietDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemChiTietDonDatHang.ImageOptions.SvgImage")));
            this.btnThemChiTietDonDatHang.Name = "btnThemChiTietDonDatHang";
            // 
            // btnMENU
            // 
            this.btnMENU.Caption = "Chọn Chế Độ";
            this.btnMENU.Id = 8;
            this.btnMENU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMENU.ImageOptions.SvgImage")));
            this.btnMENU.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoDonDatHang),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoChiTietDonDatHang)});
            this.btnMENU.Name = "btnMENU";
            // 
            // btnCheDoDonDatHang
            // 
            this.btnCheDoDonDatHang.Caption = "Đơn Đặt Hàng";
            this.btnCheDoDonDatHang.Id = 9;
            this.btnCheDoDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCheDoDonDatHang.ImageOptions.SvgImage")));
            this.btnCheDoDonDatHang.Name = "btnCheDoDonDatHang";
            // 
            // btnCheDoChiTietDonDatHang
            // 
            this.btnCheDoChiTietDonDatHang.Caption = "Chi Tiết Đơn Đặt Hàng";
            this.btnCheDoChiTietDonDatHang.Id = 10;
            this.btnCheDoChiTietDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCheDoChiTietDonDatHang.ImageOptions.SvgImage")));
            this.btnCheDoChiTietDonDatHang.Name = "btnCheDoChiTietDonDatHang";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Làm Mới";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(1918, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 1033);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(1918, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 1033);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1918, 0);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 1033);
            // 
            // formNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1033);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolBoxPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "formNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.formNhanVien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formNhanVien_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MACNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SODTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MANVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBoxPanel)).EndInit();
            this.toolBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl sidePanel;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private BankReplication.utils.BindingSourceExtends nhanVienBds;
        private NhanVienDS nhanVienDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private NhanVienDSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter1;



        private DevExpress.XtraEditors.TextEdit SODTTextEdit;
        private DevExpress.XtraEditors.TextEdit DIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit CMNDTextEdit;
        private DevExpress.XtraEditors.TextEdit TENTextEdit;
        private DevExpress.XtraEditors.TextEdit HOTextEdit;
        private DevExpress.XtraEditors.TextEdit MANVTextEdit;
        private NhanVienDSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit MACNTextEdit;
        private System.Windows.Forms.CheckBox trangThaiXoaCheckBox;
        private NhanVienDSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private System.Windows.Forms.BindingSource gD_CHUYENTIENBds;
        private NhanVienDSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private System.Windows.Forms.BindingSource gD_GOIRUTBds;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox PHAIComboBox;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl toolBoxPanel;
        private DevExpress.XtraEditors.PanelControl controlPanel;
        private DevExpress.XtraBars.BarManager toolBarManager;
        private DevExpress.XtraBars.Bar toolBar;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        public DevExpress.XtraBars.BarSubItem btnMENU;
        private DevExpress.XtraBars.BarButtonItem btnCheDoDonDatHang;
        private DevExpress.XtraBars.BarButtonItem btnCheDoChiTietDonDatHang;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private DevExpress.XtraBars.BarButtonItem btnThemChiTietDonDatHang;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCN;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.SimpleButton fBtnHuy;
        private DevExpress.XtraEditors.SimpleButton fBtnLuu;
    }
}