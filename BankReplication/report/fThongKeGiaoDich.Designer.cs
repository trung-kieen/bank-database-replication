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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formThongKeGD));
            this.tungayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.denngayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tkCmb = new System.Windows.Forms.ComboBox();
            this.accountDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDetails = new BankReplication.AccountDetails();
            this.uv_AccountDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uv_AccountDetailsTableAdapter = new BankReplication.AccountDetailsTableAdapters.uv_AccountDetailsTableAdapter();
            this.tableAdapterManager = new BankReplication.AccountDetailsTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelContainer = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tungayDateEdit
            // 
            this.tungayDateEdit.EditValue = null;
            this.tungayDateEdit.Location = new System.Drawing.Point(503, 313);
            this.tungayDateEdit.Name = "tungayDateEdit";
            this.tungayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tungayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tungayDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tungayDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tungayDateEdit.Size = new System.Drawing.Size(227, 28);
            this.tungayDateEdit.TabIndex = 2;
            // 
            // denngayDateEdit
            // 
            this.denngayDateEdit.EditValue = null;
            this.denngayDateEdit.Location = new System.Drawing.Point(503, 376);
            this.denngayDateEdit.Name = "denngayDateEdit";
            this.denngayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.denngayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.denngayDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.denngayDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.denngayDateEdit.Size = new System.Drawing.Size(227, 28);
            this.denngayDateEdit.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(350, 317);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Từ ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(350, 380);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Đến ngày";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(350, 263);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tài khoản";
            // 
            // tkCmb
            // 
            this.tkCmb.DataSource = this.accountDetailsBindingSource;
            this.tkCmb.FormattingEnabled = true;
            this.tkCmb.Location = new System.Drawing.Point(502, 255);
            this.tkCmb.Name = "tkCmb";
            this.tkCmb.Size = new System.Drawing.Size(228, 27);
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
            this.button1.Location = new System.Drawing.Point(758, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
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
            this.cmbChiNhanh.Location = new System.Drawing.Point(502, 196);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(228, 27);
            this.cmbChiNhanh.TabIndex = 9;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(350, 202);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 19);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Chi Nhánh";
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelContainer.Controls.Add(this.panelControl1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1170, 628);
            this.panelContainer.TabIndex = 11;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.tkCmb);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.tungayDateEdit);
            this.panelControl1.Controls.Add(this.denngayDateEdit);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1170, 628);
            this.panelControl1.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(531, 457);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(156, 45);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Xem thống kê";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit tungayDateEdit;
        private DevExpress.XtraEditors.DateEdit denngayDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox tkCmb;
        private System.Windows.Forms.BindingSource accountDetailsBindingSource;
        private AccountDetails accountDetails;
        private System.Windows.Forms.BindingSource uv_AccountDetailsBindingSource;
        private AccountDetailsTableAdapters.uv_AccountDetailsTableAdapter uv_AccountDetailsTableAdapter;
        private AccountDetailsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelContainer;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}