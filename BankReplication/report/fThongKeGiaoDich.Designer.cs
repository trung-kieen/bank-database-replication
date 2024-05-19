namespace BankReplication.report
{
    partial class formThongKeGD
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
            this.tungayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.denngayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tkCmb = new System.Windows.Forms.ComboBox();
            this.accountDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDetails = new BankReplication.AccountDetails();
            this.uv_AccountDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uv_AccountDetailsTableAdapter = new BankReplication.AccountDetailsTableAdapters.uv_AccountDetailsTableAdapter();
            this.tableAdapterManager = new BankReplication.AccountDetailsTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.panelContainer = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.panelControl1layoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cmbChiNhanhitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.tkCmbitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.tungayDateEdititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.denngayDateEdititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.button1item = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1layoutControl1ConvertedLayout)).BeginInit();
            this.panelControl1layoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChiNhanhitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkCmbitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1item)).BeginInit();
            this.SuspendLayout();
            // 
            // tungayDateEdit
            // 
            this.tungayDateEdit.EditValue = null;
            this.tungayDateEdit.Location = new System.Drawing.Point(108, 132);
            this.tungayDateEdit.Name = "tungayDateEdit";
            this.tungayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tungayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tungayDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tungayDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tungayDateEdit.Size = new System.Drawing.Size(408, 28);
            this.tungayDateEdit.StyleController = this.panelControl1layoutControl1ConvertedLayout;
            this.tungayDateEdit.TabIndex = 2;
            // 
            // denngayDateEdit
            // 
            this.denngayDateEdit.EditValue = null;
            this.denngayDateEdit.Location = new System.Drawing.Point(108, 184);
            this.denngayDateEdit.Name = "denngayDateEdit";
            this.denngayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.denngayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.denngayDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.denngayDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.denngayDateEdit.Size = new System.Drawing.Size(408, 28);
            this.denngayDateEdit.StyleController = this.panelControl1layoutControl1ConvertedLayout;
            this.denngayDateEdit.TabIndex = 3;
            // 
            // tkCmb
            // 
            this.tkCmb.DataSource = this.accountDetailsBindingSource;
            this.tkCmb.FormattingEnabled = true;
            this.tkCmb.Location = new System.Drawing.Point(108, 77);
            this.tkCmb.Name = "tkCmb";
            this.tkCmb.Size = new System.Drawing.Size(306, 27);
            this.tkCmb.TabIndex = 1;
            // 
            // accountDetailsBindingSource
            // 
            this.accountDetailsBindingSource.DataSource = this.accountDetails;
            this.accountDetailsBindingSource.Position = 0;
            // 
            // accountDetails
            // 
            this.accountDetails.DataSetName = "AccountDetails";
            this.accountDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uv_AccountDetailsBindingSource
            // 
            this.uv_AccountDetailsBindingSource.DataMember = "uv_AccountDetails";
            this.uv_AccountDetailsBindingSource.DataSource = this.accountDetails;
            // 
            // uv_AccountDetailsTableAdapter
            // 
            this.uv_AccountDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BankReplication.AccountDetailsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(108, 22);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(408, 27);
            this.cmbChiNhanh.TabIndex = 9;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelContainer.Controls.Add(this.panelControl1layoutControl1ConvertedLayout);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1170, 628);
            this.panelContainer.TabIndex = 11;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(12, 226);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(514, 32);
            this.simpleButton1.StyleController = this.panelControl1layoutControl1ConvertedLayout;
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Xem thống kê";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl1layoutControl1ConvertedLayout
            // 
            this.panelControl1layoutControl1ConvertedLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.cmbChiNhanh);
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.tkCmb);
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.tungayDateEdit);
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.denngayDateEdit);
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.simpleButton1);
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.button1);
            this.panelControl1layoutControl1ConvertedLayout.Location = new System.Drawing.Point(297, 151);
            this.panelControl1layoutControl1ConvertedLayout.Name = "panelControl1layoutControl1ConvertedLayout";
            this.panelControl1layoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(945, 66, 975, 600);
            this.panelControl1layoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.panelControl1layoutControl1ConvertedLayout.Size = new System.Drawing.Size(538, 322);
            this.panelControl1layoutControl1ConvertedLayout.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.cmbChiNhanhitem,
            this.tkCmbitem,
            this.tungayDateEdititem,
            this.denngayDateEdititem,
            this.simpleButton1item,
            this.button1item});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(538, 322);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // cmbChiNhanhitem
            // 
            this.cmbChiNhanhitem.Control = this.cmbChiNhanh;
            this.cmbChiNhanhitem.Location = new System.Drawing.Point(0, 0);
            this.cmbChiNhanhitem.Name = "cmbChiNhanhitem";
            this.cmbChiNhanhitem.Size = new System.Drawing.Size(518, 55);
            this.cmbChiNhanhitem.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.cmbChiNhanhitem.Text = "Chi Nhánh";
            this.cmbChiNhanhitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.cmbChiNhanhitem.TextSize = new System.Drawing.Size(74, 19);
            // 
            // tkCmbitem
            // 
            this.tkCmbitem.Control = this.tkCmb;
            this.tkCmbitem.Location = new System.Drawing.Point(0, 55);
            this.tkCmbitem.Name = "tkCmbitem";
            this.tkCmbitem.Size = new System.Drawing.Size(416, 55);
            this.tkCmbitem.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.tkCmbitem.Text = "Tài khoản";
            this.tkCmbitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.tkCmbitem.TextSize = new System.Drawing.Size(74, 19);
            // 
            // tungayDateEdititem
            // 
            this.tungayDateEdititem.Control = this.tungayDateEdit;
            this.tungayDateEdititem.Location = new System.Drawing.Point(0, 110);
            this.tungayDateEdititem.Name = "tungayDateEdititem";
            this.tungayDateEdititem.Size = new System.Drawing.Size(518, 52);
            this.tungayDateEdititem.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.tungayDateEdititem.Text = "Từ ngày";
            this.tungayDateEdititem.TextLocation = DevExpress.Utils.Locations.Left;
            this.tungayDateEdititem.TextSize = new System.Drawing.Size(74, 19);
            // 
            // denngayDateEdititem
            // 
            this.denngayDateEdititem.Control = this.denngayDateEdit;
            this.denngayDateEdititem.Location = new System.Drawing.Point(0, 162);
            this.denngayDateEdititem.Name = "denngayDateEdititem";
            this.denngayDateEdititem.Size = new System.Drawing.Size(518, 52);
            this.denngayDateEdititem.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.denngayDateEdititem.Text = "Đến ngày";
            this.denngayDateEdititem.TextLocation = DevExpress.Utils.Locations.Left;
            this.denngayDateEdititem.TextSize = new System.Drawing.Size(74, 19);
            // 
            // simpleButton1item
            // 
            this.simpleButton1item.Control = this.simpleButton1;
            this.simpleButton1item.Location = new System.Drawing.Point(0, 214);
            this.simpleButton1item.Name = "simpleButton1item";
            this.simpleButton1item.Size = new System.Drawing.Size(518, 88);
            this.simpleButton1item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton1item.TextVisible = false;
            // 
            // button1item
            // 
            this.button1item.Control = this.button1;
            this.button1item.Location = new System.Drawing.Point(416, 55);
            this.button1item.Name = "button1item";
            this.button1item.Size = new System.Drawing.Size(102, 55);
            this.button1item.TextSize = new System.Drawing.Size(0, 0);
            this.button1item.TextVisible = false;
            // 
            // formThongKeGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 628);
            this.Controls.Add(this.panelContainer);
            this.Name = "formThongKeGD";
            this.Text = "Thống kê giao dịch";
            this.Load += new System.EventHandler(this.formThongKeGD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).EndInit();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1layoutControl1ConvertedLayout)).EndInit();
            this.panelControl1layoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChiNhanhitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkCmbitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit tungayDateEdit;
        private DevExpress.XtraEditors.DateEdit denngayDateEdit;
        private System.Windows.Forms.ComboBox tkCmb;
        private System.Windows.Forms.BindingSource accountDetailsBindingSource;
        private AccountDetails accountDetails;
        private System.Windows.Forms.BindingSource uv_AccountDetailsBindingSource;
        private AccountDetailsTableAdapters.uv_AccountDetailsTableAdapter uv_AccountDetailsTableAdapter;
        private AccountDetailsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.PanelControl panelContainer;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControl panelControl1layoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem cmbChiNhanhitem;
        private DevExpress.XtraLayout.LayoutControlItem tkCmbitem;
        private DevExpress.XtraLayout.LayoutControlItem tungayDateEdititem;
        private DevExpress.XtraLayout.LayoutControlItem denngayDateEdititem;
        private DevExpress.XtraLayout.LayoutControlItem simpleButton1item;
        private DevExpress.XtraLayout.LayoutControlItem button1item;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}