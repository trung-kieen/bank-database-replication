﻿namespace BankReplication.form
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
            this.pHAIComboBox = new System.Windows.Forms.ComboBox();
            this.nhanVienBds = new BankReplication.utils.BindingSourceExtends(this.components);
            this.nhanVienDS1 = new BankReplication.NhanVienDS();
            this.trangThaiXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.mACNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sODTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mANVTextEdit = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.mACNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANVTextEdit.Properties)).BeginInit();
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
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(66, 79);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(59, 19);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MANV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(87, 129);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(38, 19);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(81, 175);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(45, 19);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
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
            dIACHILabel.Location = new System.Drawing.Point(56, 273);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(70, 19);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(69, 367);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(57, 19);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "SODT:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(66, 415);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(59, 19);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "MACN:";
            // 
            // pHAILabel1
            // 
            pHAILabel1.AutoSize = true;
            pHAILabel1.Location = new System.Drawing.Point(73, 320);
            pHAILabel1.Name = "pHAILabel1";
            pHAILabel1.Size = new System.Drawing.Size(52, 19);
            pHAILabel1.TabIndex = 18;
            pHAILabel1.Text = "PHAI:";
            // 
            // sidePanel
            // 
            this.sidePanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.sidePanel.Appearance.Options.UseBackColor = true;
            this.sidePanel.Controls.Add(pHAILabel1);
            this.sidePanel.Controls.Add(this.pHAIComboBox);
            this.sidePanel.Controls.Add(this.trangThaiXoaCheckBox);
            this.sidePanel.Controls.Add(mACNLabel);
            this.sidePanel.Controls.Add(this.mACNTextEdit);
            this.sidePanel.Controls.Add(sODTLabel);
            this.sidePanel.Controls.Add(this.sODTTextEdit);
            this.sidePanel.Controls.Add(dIACHILabel);
            this.sidePanel.Controls.Add(this.dIACHITextEdit);
            this.sidePanel.Controls.Add(cMNDLabel);
            this.sidePanel.Controls.Add(this.cMNDTextEdit);
            this.sidePanel.Controls.Add(tENLabel);
            this.sidePanel.Controls.Add(this.tENTextEdit);
            this.sidePanel.Controls.Add(hOLabel);
            this.sidePanel.Controls.Add(this.hOTextEdit);
            this.sidePanel.Controls.Add(mANVLabel);
            this.sidePanel.Controls.Add(this.mANVTextEdit);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(2, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(389, 939);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.Visible = false;
            // 
            // pHAIComboBox
            // 
            this.pHAIComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBds, "PHAI", true));
            this.pHAIComboBox.FormattingEnabled = true;
            this.pHAIComboBox.Location = new System.Drawing.Point(132, 317);
            this.pHAIComboBox.Name = "pHAIComboBox";
            this.pHAIComboBox.Size = new System.Drawing.Size(150, 27);
            this.pHAIComboBox.TabIndex = 10;
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
            // 
            // mACNTextEdit
            // 
            this.mACNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "MACN", true));
            this.mACNTextEdit.Enabled = false;
            this.mACNTextEdit.Location = new System.Drawing.Point(132, 412);
            this.mACNTextEdit.Name = "mACNTextEdit";
            this.mACNTextEdit.Size = new System.Drawing.Size(150, 28);
            this.mACNTextEdit.TabIndex = 15;
            // 
            // sODTTextEdit
            // 
            this.sODTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "SODT", true));
            this.sODTTextEdit.Location = new System.Drawing.Point(132, 364);
            this.sODTTextEdit.Name = "sODTTextEdit";
            this.sODTTextEdit.Properties.MaxLength = 15;
            this.sODTTextEdit.Size = new System.Drawing.Size(150, 28);
            this.sODTTextEdit.TabIndex = 11;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(132, 270);
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Properties.MaxLength = 100;
            this.dIACHITextEdit.Size = new System.Drawing.Size(150, 28);
            this.dIACHITextEdit.TabIndex = 9;
            // 
            // cMNDTextEdit
            // 
            this.cMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "CMND", true));
            this.cMNDTextEdit.Location = new System.Drawing.Point(132, 219);
            this.cMNDTextEdit.Name = "cMNDTextEdit";
            this.cMNDTextEdit.Properties.MaxLength = 10;
            this.cMNDTextEdit.Size = new System.Drawing.Size(150, 28);
            this.cMNDTextEdit.TabIndex = 7;
            // 
            // tENTextEdit
            // 
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "TEN", true));
            this.tENTextEdit.Location = new System.Drawing.Point(132, 172);
            this.tENTextEdit.Name = "tENTextEdit";
            this.tENTextEdit.Properties.MaxLength = 10;
            this.tENTextEdit.Size = new System.Drawing.Size(150, 28);
            this.tENTextEdit.TabIndex = 5;
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "HO", true));
            this.hOTextEdit.Location = new System.Drawing.Point(132, 126);
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Properties.MaxLength = 50;
            this.hOTextEdit.Size = new System.Drawing.Size(150, 28);
            this.hOTextEdit.TabIndex = 3;
            // 
            // mANVTextEdit
            // 
            this.mANVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "MANV", true));
            this.mANVTextEdit.Location = new System.Drawing.Point(132, 76);
            this.mANVTextEdit.Name = "mANVTextEdit";
            this.mANVTextEdit.Properties.MaxLength = 10;
            this.mANVTextEdit.Size = new System.Drawing.Size(150, 28);
            this.mANVTextEdit.TabIndex = 1;
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.nhanVienBds;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhanVien.Location = new System.Drawing.Point(2, 2);
            this.gcNhanVien.MainView = this.gvNhanVien;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1914, 939);
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
            this.panelControl1.Location = new System.Drawing.Point(0, 70);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1918, 943);
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
            this.panelControl3.Size = new System.Drawing.Size(1914, 32);
            this.panelControl3.TabIndex = 2;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(105, 3);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(177, 27);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 8);
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
            this.toolBoxPanel.Size = new System.Drawing.Size(1918, 36);
            this.toolBoxPanel.TabIndex = 1;
            // 
            // controlPanel
            // 
            this.controlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(2, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1914, 32);
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
            this.btnHuy});
            this.toolBarManager.MainMenu = this.toolBar;
            this.toolBarManager.MaxItemId = 14;
            this.toolBarManager.StatusBar = this.bar3;
            // 
            // toolBar
            // 
            this.toolBar.BarName = "Main menu";
            this.toolBar.DockCol = 0;
            this.toolBar.DockRow = 0;
            this.toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.toolBar.FloatLocation = new System.Drawing.Point(40, 296);
            this.toolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 11;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
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
            // formNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1918, 1033);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolBoxPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.formNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANVTextEdit.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit sODTTextEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit cMNDTextEdit;
        private DevExpress.XtraEditors.TextEdit tENTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private DevExpress.XtraEditors.TextEdit mANVTextEdit;
        private NhanVienDSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit mACNTextEdit;
        private System.Windows.Forms.CheckBox trangThaiXoaCheckBox;
        private NhanVienDSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private System.Windows.Forms.BindingSource gD_CHUYENTIENBds;
        private NhanVienDSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private System.Windows.Forms.BindingSource gD_GOIRUTBds;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox pHAIComboBox;
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
    }
}