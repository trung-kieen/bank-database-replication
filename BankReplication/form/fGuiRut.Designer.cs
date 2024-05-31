namespace BankReplication.form
{
    partial class formGuiRut
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
            this.panelContainer = new DevExpress.XtraEditors.PanelControl();
            this.txtSoDu = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.btnGuiRut = new System.Windows.Forms.Button();
            this.loaiGDCmb = new System.Windows.Forms.ComboBox();
            this.tkCmb = new System.Windows.Forms.ComboBox();
            this.uv_AccountDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDetails = new BankReplication.AccountDetails();
            this.uv_AccountDetailsTableAdapter = new BankReplication.AccountDetailsTableAdapters.uv_AccountDetailsTableAdapter();
            this.tableAdapterManager = new BankReplication.AccountDetailsTableAdapters.TableAdapterManager();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelContainer.Controls.Add(this.layoutControl1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(798, 553);
            this.panelContainer.TabIndex = 0;
            // 
            // txtSoDu
            // 
            this.txtSoDu.Location = new System.Drawing.Point(130, 81);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(292, 28);
            this.txtSoDu.StyleController = this.layoutControl1;
            this.txtSoDu.TabIndex = 2;
            this.txtSoDu.TabStop = false;
            // 
            // txtSoTien
            // 


            txtSoDu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtSoDu.Properties.Mask.EditMask = "n0";
            txtSoDu.Properties.Mask.UseMaskAsDisplayFormat = true;

            txtSoTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtSoTien.Properties.Mask.EditMask = "n0";
            txtSoTien.Properties.Mask.UseMaskAsDisplayFormat = true;

            this.txtSoTien.Location = new System.Drawing.Point(130, 129);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Properties.EditFormat.FormatString = "n0";
            this.txtSoTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTien.Size = new System.Drawing.Size(292, 28);
            this.txtSoTien.StyleController = this.layoutControl1;
            this.txtSoTien.TabIndex = 3;
            this.txtSoTien.EditValueChanged += new System.EventHandler(this.txtSoTien_EditValueChanged);
            this.txtSoTien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoTien_KeyDown);
            // 
            // btnGuiRut
            // 
            this.btnGuiRut.Location = new System.Drawing.Point(12, 220);
            this.btnGuiRut.Name = "btnGuiRut";
            this.btnGuiRut.Size = new System.Drawing.Size(418, 30);
            this.btnGuiRut.TabIndex = 7;
            this.btnGuiRut.Text = "Thực hiện";
            this.btnGuiRut.UseVisualStyleBackColor = true;
            this.btnGuiRut.Click += new System.EventHandler(this.btnGuiRut_Click);
            // 
            // loaiGDCmb
            // 
            this.loaiGDCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loaiGDCmb.FormattingEnabled = true;
            this.loaiGDCmb.Location = new System.Drawing.Point(130, 177);
            this.loaiGDCmb.Name = "loaiGDCmb";
            this.loaiGDCmb.Size = new System.Drawing.Size(292, 27);
            this.loaiGDCmb.TabIndex = 4;
            // 
            // tkCmb
            // 
            this.tkCmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uv_AccountDetailsBindingSource, "SOTK", true));
            this.tkCmb.FormattingEnabled = true;
            this.tkCmb.Location = new System.Drawing.Point(130, 30);
            this.tkCmb.Name = "tkCmb";
            this.tkCmb.Size = new System.Drawing.Size(292, 27);
            this.tkCmb.TabIndex = 1;
            // 
            // uv_AccountDetailsBindingSource
            // 
            this.uv_AccountDetailsBindingSource.DataMember = "uv_AccountDetails";
            this.uv_AccountDetailsBindingSource.DataSource = this.accountDetails;
            // 
            // accountDetails
            // 
            this.accountDetails.DataSetName = "AccountDetails";
            this.accountDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // layoutControl1
            // 
            this.layoutControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.layoutControl1.Controls.Add(this.txtSoTien);
            this.layoutControl1.Controls.Add(this.btnGuiRut);
            this.layoutControl1.Controls.Add(this.txtSoDu);
            this.layoutControl1.Controls.Add(this.loaiGDCmb);
            this.layoutControl1.Controls.Add(this.tkCmb);
            this.layoutControl1.Location = new System.Drawing.Point(183, 127);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(704, 0, 975, 600);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(442, 283);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(442, 283);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tkCmb;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 10);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(422, 51);
            this.layoutControlItem1.Text = "Tài khoản";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(98, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSoDu;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(422, 48);
            this.layoutControlItem2.Text = "Số dư";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(98, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtSoTien;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 109);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(422, 48);
            this.layoutControlItem3.Text = "Số tiền";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(98, 19);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.loaiGDCmb;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 157);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(422, 51);
            this.layoutControlItem4.Text = "Loại giao dịch";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(98, 19);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnGuiRut;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 208);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(422, 34);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 242);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(422, 21);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(422, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // formGuiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 553);
            this.Controls.Add(this.panelContainer);
            this.Name = "formGuiRut";
            this.Text = "Giao dịch gửi/rút tiền";
            this.Load += new System.EventHandler(this.fGuiRut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).EndInit();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelContainer;
        private AccountDetails accountDetails;
        private System.Windows.Forms.BindingSource uv_AccountDetailsBindingSource;
        private AccountDetailsTableAdapters.uv_AccountDetailsTableAdapter uv_AccountDetailsTableAdapter;
        private AccountDetailsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tkCmb;
        private System.Windows.Forms.ComboBox loaiGDCmb;
        private System.Windows.Forms.Button btnGuiRut;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private DevExpress.XtraEditors.TextEdit txtSoDu;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}