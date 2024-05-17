namespace BankReplication.form
{
    partial class formChuyenTien
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
            this.tkNhanCmb = new System.Windows.Forms.ComboBox();
            this.uv_AccountDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDetails = new BankReplication.AccountDetails();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDu = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChuyenTien = new System.Windows.Forms.Button();
            this.tkNguonCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uv_AccountDetailsTableAdapter = new BankReplication.AccountDetailsTableAdapters.uv_AccountDetailsTableAdapter();
            this.tableAdapterManager = new BankReplication.AccountDetailsTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelContainer.Controls.Add(this.tkNhanCmb);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.txtSoDu);
            this.panelContainer.Controls.Add(this.txtSoTien);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.btnChuyenTien);
            this.panelContainer.Controls.Add(this.tkNguonCmb);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(798, 553);
            this.panelContainer.TabIndex = 0;
            // 
            // tkNhanCmb
            // 
            this.tkNhanCmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uv_AccountDetailsBindingSource, "SOTK", true));
            this.tkNhanCmb.FormattingEnabled = true;
            this.tkNhanCmb.Location = new System.Drawing.Point(316, 238);
            this.tkNhanCmb.Name = "tkNhanCmb";
            this.tkNhanCmb.Size = new System.Drawing.Size(217, 27);
            this.tkNhanCmb.TabIndex = 4;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tài khoản nhận";
            // 
            // txtSoDu
            // 
            this.txtSoDu.Location = new System.Drawing.Point(316, 146);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(217, 28);
            this.txtSoDu.TabIndex = 2;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(316, 188);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Properties.EditFormat.FormatString = "n0";
            this.txtSoTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTien.Size = new System.Drawing.Size(217, 28);
            this.txtSoTien.TabIndex = 3;
            this.txtSoTien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoTien_KeyDown);
            this.tkNguonCmb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoTien_KeyDown);
            this.tkNhanCmb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoTien_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số dư";
            // 
            // btnGuiRut
            // 
            this.btnChuyenTien.Location = new System.Drawing.Point(340, 300);
            this.btnChuyenTien.Name = "btnGuiRut";
            this.btnChuyenTien.Size = new System.Drawing.Size(124, 41);
            this.btnChuyenTien.TabIndex = 7;
            this.btnChuyenTien.Text = "Chuyển tiền";
            this.btnChuyenTien.UseVisualStyleBackColor = true;
            this.btnChuyenTien.Click += new System.EventHandler(this.btnChuyenTien_Click);
            // 
            // tkNguonCmb
            // 
            this.tkNguonCmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uv_AccountDetailsBindingSource, "SOTK", true));
            this.tkNguonCmb.FormattingEnabled = true;
            this.tkNguonCmb.Location = new System.Drawing.Point(316, 103);
            this.tkNguonCmb.Name = "tkNguonCmb";
            this.tkNguonCmb.Size = new System.Drawing.Size(217, 27);
            this.tkNguonCmb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản nguồn";
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
            // formChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 553);
            this.Controls.Add(this.panelContainer);
            this.Name = "formChuyenTien";
            this.Text = "Giao dịch chuyển tiền";
            this.Load += new System.EventHandler(this.fChuyenTienLoad);
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AccountDetails accountDetails;
        private System.Windows.Forms.BindingSource uv_AccountDetailsBindingSource;
        private AccountDetailsTableAdapters.uv_AccountDetailsTableAdapter uv_AccountDetailsTableAdapter;
        private AccountDetailsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tkNguonCmb;
        private System.Windows.Forms.Button btnChuyenTien;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private DevExpress.XtraEditors.TextEdit txtSoDu;
        private System.Windows.Forms.ComboBox tkNhanCmb;
        private System.Windows.Forms.Label label5;
    }
}