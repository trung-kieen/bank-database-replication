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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNhanVien));
            this.sidePanel = new DevExpress.XtraEditors.PanelControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.nhanVienBds = new BankReplication.utils.BindingSourceExtends(this.components);
            this.nhanVienDS1 = new BankReplication.NhanVienDS();
            this.fBtnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.fBtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.trangThaiXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.PHAIComboBox = new System.Windows.Forms.ComboBox();
            this.HOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MACNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MANVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SODTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlPhaiTxt = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
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
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.nhanVienTableAdapter1 = new BankReplication.NhanVienDSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new BankReplication.NhanVienDSTableAdapters.TableAdapterManager();
            this.gD_CHUYENTIENTableAdapter = new BankReplication.NhanVienDSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.gD_GOIRUTTableAdapter = new BankReplication.NhanVienDSTableAdapters.GD_GOIRUTTableAdapter();
            this.gD_CHUYENTIENBds = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTBds = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
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
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MACNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MANVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SODTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPhaiTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBoxPanel)).BeginInit();
            this.toolBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.sidePanel.Appearance.Options.UseBackColor = true;
            this.tablePanel1.SetColumn(this.sidePanel, 1);
            this.sidePanel.Controls.Add(this.dataLayoutControl1);
            this.sidePanel.Location = new System.Drawing.Point(1421, 3);
            this.sidePanel.Name = "sidePanel";
            this.tablePanel1.SetRow(this.sidePanel, 0);
            this.sidePanel.Size = new System.Drawing.Size(490, 923);
            this.sidePanel.TabIndex = 0;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txtPhai);
            this.dataLayoutControl1.Controls.Add(this.fBtnHuy);
            this.dataLayoutControl1.Controls.Add(this.fBtnLuu);
            this.dataLayoutControl1.Controls.Add(this.trangThaiXoaCheckBox);
            this.dataLayoutControl1.Controls.Add(this.PHAIComboBox);
            this.dataLayoutControl1.Controls.Add(this.HOTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MACNTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MANVTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TENTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SODTTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CMNDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DIACHITextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlPhaiTxt});
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(596, 0, 975, 600);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(486, 919);
            this.dataLayoutControl1.TabIndex = 21;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txtPhai
            // 
            this.txtPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBds, "PHAI", true));
            this.txtPhai.Location = new System.Drawing.Point(130, 867);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(334, 30);
            this.txtPhai.TabIndex = 21;
            this.txtPhai.Visible = false;
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
            // fBtnHuy
            // 
            this.fBtnHuy.Location = new System.Drawing.Point(244, 505);
            this.fBtnHuy.Name = "fBtnHuy";
            this.fBtnHuy.Size = new System.Drawing.Size(220, 32);
            this.fBtnHuy.StyleController = this.dataLayoutControl1;
            this.fBtnHuy.TabIndex = 20;
            this.fBtnHuy.Text = "Hủy";
            this.fBtnHuy.Click += new System.EventHandler(this.fBtnHuy_Click);
            // 
            // fBtnLuu
            // 
            this.fBtnLuu.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.fBtnLuu.Appearance.Options.UseBackColor = true;
            this.fBtnLuu.Location = new System.Drawing.Point(22, 505);
            this.fBtnLuu.Name = "fBtnLuu";
            this.fBtnLuu.Size = new System.Drawing.Size(218, 32);
            this.fBtnLuu.StyleController = this.dataLayoutControl1;
            this.fBtnLuu.TabIndex = 19;
            this.fBtnLuu.Text = "Lưu";
            this.fBtnLuu.Click += new System.EventHandler(this.fBtnLuu_Click);
            // 
            // trangThaiXoaCheckBox
            // 
            this.trangThaiXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nhanVienBds, "TrangThaiXoa", true));
            this.trangThaiXoaCheckBox.Enabled = false;
            this.trangThaiXoaCheckBox.Location = new System.Drawing.Point(25, 468);
            this.trangThaiXoaCheckBox.Name = "trangThaiXoaCheckBox";
            this.trangThaiXoaCheckBox.Size = new System.Drawing.Size(436, 30);
            this.trangThaiXoaCheckBox.TabIndex = 17;
            this.trangThaiXoaCheckBox.Text = "Trạng thái xóa";
            this.trangThaiXoaCheckBox.UseVisualStyleBackColor = true;
            this.trangThaiXoaCheckBox.Visible = false;
            // 
            // PHAIComboBox
            // 
            this.PHAIComboBox.DisplayMember = "Text";
            this.PHAIComboBox.FormattingEnabled = true;
            this.PHAIComboBox.Location = new System.Drawing.Point(133, 351);
            this.PHAIComboBox.Name = "PHAIComboBox";
            this.PHAIComboBox.Size = new System.Drawing.Size(328, 27);
            this.PHAIComboBox.TabIndex = 10;
            this.PHAIComboBox.ValueMember = "Value";
            this.PHAIComboBox.SelectedIndexChanged += new System.EventHandler(this.PHAIComboBox_SelectedIndexChanged);
            // 
            // HOTextEdit
            // 
            this.HOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "HO", true));
            this.HOTextEdit.Location = new System.Drawing.Point(133, 199);
            this.HOTextEdit.Name = "HOTextEdit";
            this.HOTextEdit.Properties.MaxLength = 50;
            this.HOTextEdit.Size = new System.Drawing.Size(328, 28);
            this.HOTextEdit.StyleController = this.dataLayoutControl1;
            this.HOTextEdit.TabIndex = 3;
            this.HOTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // MACNTextEdit
            // 
            this.MACNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "MACN", true));
            this.MACNTextEdit.Enabled = false;
            this.MACNTextEdit.Location = new System.Drawing.Point(133, 430);
            this.MACNTextEdit.Name = "MACNTextEdit";
            this.MACNTextEdit.Size = new System.Drawing.Size(328, 28);
            this.MACNTextEdit.StyleController = this.dataLayoutControl1;
            this.MACNTextEdit.TabIndex = 15;
            this.MACNTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // MANVTextEdit
            // 
            this.MANVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "MANV", true));
            this.MANVTextEdit.Location = new System.Drawing.Point(133, 161);
            this.MANVTextEdit.Name = "MANVTextEdit";
            this.MANVTextEdit.Properties.MaxLength = 10;
            this.MANVTextEdit.Size = new System.Drawing.Size(328, 28);
            this.MANVTextEdit.StyleController = this.dataLayoutControl1;
            this.MANVTextEdit.TabIndex = 1;
            this.MANVTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // TENTextEdit
            // 
            this.TENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "TEN", true));
            this.TENTextEdit.Location = new System.Drawing.Point(133, 237);
            this.TENTextEdit.Name = "TENTextEdit";
            this.TENTextEdit.Properties.MaxLength = 10;
            this.TENTextEdit.Size = new System.Drawing.Size(328, 28);
            this.TENTextEdit.StyleController = this.dataLayoutControl1;
            this.TENTextEdit.TabIndex = 5;
            this.TENTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // SODTTextEdit
            // 
            this.SODTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "SODT", true));
            this.SODTTextEdit.Location = new System.Drawing.Point(133, 392);
            this.SODTTextEdit.Name = "SODTTextEdit";
            this.SODTTextEdit.Properties.MaxLength = 15;
            this.SODTTextEdit.Size = new System.Drawing.Size(328, 28);
            this.SODTTextEdit.StyleController = this.dataLayoutControl1;
            this.SODTTextEdit.TabIndex = 11;
            this.SODTTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // CMNDTextEdit
            // 
            this.CMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "CMND", true));
            this.CMNDTextEdit.Location = new System.Drawing.Point(133, 275);
            this.CMNDTextEdit.Name = "CMNDTextEdit";
            this.CMNDTextEdit.Properties.MaxLength = 10;
            this.CMNDTextEdit.Size = new System.Drawing.Size(328, 28);
            this.CMNDTextEdit.StyleController = this.dataLayoutControl1;
            this.CMNDTextEdit.TabIndex = 7;
            this.CMNDTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // DIACHITextEdit
            // 
            this.DIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBds, "DIACHI", true));
            this.DIACHITextEdit.Location = new System.Drawing.Point(133, 313);
            this.DIACHITextEdit.Name = "DIACHITextEdit";
            this.DIACHITextEdit.Properties.MaxLength = 100;
            this.DIACHITextEdit.Size = new System.Drawing.Size(328, 28);
            this.DIACHITextEdit.StyleController = this.dataLayoutControl1;
            this.DIACHITextEdit.TabIndex = 9;
            this.DIACHITextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // layoutControlPhaiTxt
            // 
            this.layoutControlPhaiTxt.Control = this.txtPhai;
            this.layoutControlPhaiTxt.Location = new System.Drawing.Point(0, 845);
            this.layoutControlPhaiTxt.Name = "layoutControlPhaiTxt";
            this.layoutControlPhaiTxt.Size = new System.Drawing.Size(446, 34);
            this.layoutControlPhaiTxt.Text = "Phái";
            this.layoutControlPhaiTxt.TextSize = new System.Drawing.Size(105, 19);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem3,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(486, 919);
            this.Root.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.HOTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 174);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Size = new System.Drawing.Size(446, 38);
            this.layoutControlItem1.Text = "Họ:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(105, 19);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 519);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(446, 360);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.MANVTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 136);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Size = new System.Drawing.Size(446, 38);
            this.layoutControlItem2.Text = "Mã nhân viên:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(105, 19);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CMNDTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 250);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(446, 38);
            this.layoutControlItem4.Text = "CMND:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(105, 19);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.DIACHITextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 288);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem5.Size = new System.Drawing.Size(446, 38);
            this.layoutControlItem5.Text = "Địa chỉ:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(105, 19);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.PHAIComboBox;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 326);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem6.Size = new System.Drawing.Size(446, 41);
            this.layoutControlItem6.Text = "Phái: ";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(105, 19);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.SODTTextEdit;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 367);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem7.Size = new System.Drawing.Size(446, 38);
            this.layoutControlItem7.Text = "Số điện thoại: ";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(105, 19);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.MACNTextEdit;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 405);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem8.Size = new System.Drawing.Size(446, 38);
            this.layoutControlItem8.Text = "Mã chi nhánh: ";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(105, 19);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.trangThaiXoaCheckBox;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 443);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem9.Size = new System.Drawing.Size(446, 40);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TENTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 212);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem3.Size = new System.Drawing.Size(446, 38);
            this.layoutControlItem3.Text = "Tên: ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(105, 19);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.fBtnLuu;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 483);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(222, 36);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.fBtnHuy;
            this.layoutControlItem11.Location = new System.Drawing.Point(222, 483);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(224, 36);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(446, 136);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gcNhanVien
            // 
            this.tablePanel1.SetColumn(this.gcNhanVien, 0);
            this.gcNhanVien.DataSource = this.nhanVienBds;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhanVien.Location = new System.Drawing.Point(3, 3);
            this.gcNhanVien.MainView = this.gvNhanVien;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckedComboBoxEdit1});
            this.tablePanel1.SetRow(this.gcNhanVien, 0);
            this.gcNhanVien.Size = new System.Drawing.Size(1412, 923);
            this.gcNhanVien.TabIndex = 2;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien});
            this.gcNhanVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcNhanVien_KeyDown);
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
            this.gvNhanVien.CustomizationFormBounds = new System.Drawing.Rectangle(1169, 637, 377, 383);
            this.gvNhanVien.DetailHeight = 349;
            this.gvNhanVien.FixedLineWidth = 1;
            this.gvNhanVien.GridControl = this.gcNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.OptionsBehavior.Editable = false;
            this.gvNhanVien.OptionsClipboard.ShowProgress = DevExpress.Export.ProgressMode.Never;
            this.gvNhanVien.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvNhanVien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNhanVien_FocusedRowChanged);
            this.gvNhanVien.DoubleClick += new System.EventHandler(this.gvNhanVien_DoubleClick);
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 30;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 112;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
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
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 112;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 30;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 5;
            this.colPHAI.Width = 112;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 30;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 112;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
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
            this.colTrangThaiXoa.Caption = "Trạng thái xóa";
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 30;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 8;
            this.colTrangThaiXoa.Width = 112;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
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
            this.panelControl1.Controls.Add(this.tablePanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 80);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1918, 933);
            this.panelControl1.TabIndex = 3;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 44.45F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 15.55F)});
            this.tablePanel1.Controls.Add(this.gcNhanVien);
            this.tablePanel1.Controls.Add(this.sidePanel);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(2, 2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1914, 929);
            this.tablePanel1.TabIndex = 3;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.cmbChiNhanh);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1914, 42);
            this.panelControl3.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chi Nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(105, 8);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(240, 27);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
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
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.formNhanVien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formNhanVien_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MACNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MANVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SODTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPhaiTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBoxPanel)).EndInit();
            this.toolBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
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
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private TextBox txtPhai;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlPhaiTxt;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}