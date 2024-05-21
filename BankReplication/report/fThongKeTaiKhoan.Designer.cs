namespace BankReplication.report
{
    partial class formThongKeTK
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
            this.accountDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDetails = new BankReplication.AccountDetails();
            this.uv_AccountDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uv_AccountDetailsTableAdapter = new BankReplication.AccountDetailsTableAdapters.uv_AccountDetailsTableAdapter();
            this.tableAdapterManager = new BankReplication.AccountDetailsTableAdapters.TableAdapterManager();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.panelContainer = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.denngayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tungayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.checkAllSite = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.controlAllSiteCheck = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAllSiteCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
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
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(97, 40);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(266, 27);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelContainer.Controls.Add(this.panelControl1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(798, 553);
            this.panelContainer.TabIndex = 11;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Location = new System.Drawing.Point(197, 103);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(403, 310);
            this.panelControl1.TabIndex = 10;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.denngayDateEdit);
            this.layoutControl1.Controls.Add(this.tungayDateEdit);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.cmbChiNhanh);
            this.layoutControl1.Controls.Add(this.checkAllSite);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(802, 0, 975, 600);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(403, 310);
            this.layoutControl1.TabIndex = 11;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // denngayDateEdit
            // 
            this.denngayDateEdit.EditValue = null;
            this.denngayDateEdit.Location = new System.Drawing.Point(99, 198);
            this.denngayDateEdit.Name = "denngayDateEdit";
            this.denngayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.denngayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.denngayDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.denngayDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.denngayDateEdit.Size = new System.Drawing.Size(282, 28);
            this.denngayDateEdit.StyleController = this.layoutControl1;
            this.denngayDateEdit.TabIndex = 4;
            // 
            // tungayDateEdit
            // 
            this.tungayDateEdit.EditValue = null;
            this.tungayDateEdit.Location = new System.Drawing.Point(99, 146);
            this.tungayDateEdit.Name = "tungayDateEdit";
            this.tungayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tungayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tungayDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tungayDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tungayDateEdit.Size = new System.Drawing.Size(282, 28);
            this.tungayDateEdit.StyleController = this.layoutControl1;
            this.tungayDateEdit.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 240);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(379, 32);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Xem thống kê";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // checkAllSite
            // 
            this.checkAllSite.Location = new System.Drawing.Point(12, 103);
            this.checkAllSite.Margin = new System.Windows.Forms.Padding(20);
            this.checkAllSite.Name = "checkAllSite";
            this.checkAllSite.Properties.Caption = "Tất cả chi nhánh";
            this.checkAllSite.Size = new System.Drawing.Size(379, 29);
            this.checkAllSite.StyleController = this.layoutControl1;
            this.checkAllSite.TabIndex = 2;
            this.checkAllSite.CheckedChanged += new System.EventHandler(this.checkAllSite_CheckedChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.controlAllSiteCheck,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(403, 310);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbChiNhanh;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 20, 20, 20);
            this.layoutControlItem1.Size = new System.Drawing.Size(383, 91);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Text = "Chi Nhánh";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 19);
            // 
            // controlAllSiteCheck
            // 
            this.controlAllSiteCheck.Control = this.checkAllSite;
            this.controlAllSiteCheck.Location = new System.Drawing.Point(0, 91);
            this.controlAllSiteCheck.Name = "controlAllSiteCheck";
            this.controlAllSiteCheck.Size = new System.Drawing.Size(383, 33);
            this.controlAllSiteCheck.TextSize = new System.Drawing.Size(0, 0);
            this.controlAllSiteCheck.TextVisible = false;
            this.controlAllSiteCheck.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 228);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(383, 62);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tungayDateEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(383, 52);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Text = "Từ ngày";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 19);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.denngayDateEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 176);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(383, 52);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Text = "Đến ngày";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(74, 19);
            // 
            // formThongKeTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 553);
            this.Controls.Add(this.panelContainer);
            this.Name = "formThongKeTK";
            this.Text = "Thống kê khách hàng";
            this.Load += new System.EventHandler(this.thongKeTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).EndInit();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAllSiteCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource accountDetailsBindingSource;
        private AccountDetails accountDetails;
        private System.Windows.Forms.BindingSource uv_AccountDetailsBindingSource;
        private AccountDetailsTableAdapters.uv_AccountDetailsTableAdapter uv_AccountDetailsTableAdapter;
        private AccountDetailsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.PanelControl panelContainer;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.CheckEdit checkAllSite;
        private DevExpress.XtraLayout.LayoutControlItem controlAllSiteCheck;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit tungayDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DateEdit denngayDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}