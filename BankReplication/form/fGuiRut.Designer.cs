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
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuiRut = new System.Windows.Forms.Button();
            this.loaiGDCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tkCmb = new System.Windows.Forms.ComboBox();
            this.uv_AccountDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDetails = new BankReplication.AccountDetails();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uv_AccountDetailsTableAdapter = new BankReplication.AccountDetailsTableAdapters.uv_AccountDetailsTableAdapter();
            this.tableAdapterManager = new BankReplication.AccountDetailsTableAdapters.TableAdapterManager();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelContainer.Controls.Add(this.txtSoDu);
            this.panelContainer.Controls.Add(this.txtSoTien);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.btnGuiRut);
            this.panelContainer.Controls.Add(this.loaiGDCmb);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.tkCmb);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(798, 553);
            this.panelContainer.TabIndex = 0;
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
            this.btnGuiRut.Location = new System.Drawing.Point(318, 318);
            this.btnGuiRut.Name = "btnGuiRut";
            this.btnGuiRut.Size = new System.Drawing.Size(124, 41);
            this.btnGuiRut.TabIndex = 7;
            this.btnGuiRut.Text = "Gửi/Rút";
            this.btnGuiRut.UseVisualStyleBackColor = true;
            this.btnGuiRut.Click += new System.EventHandler(this.btnGuiRut_Click);
            // 
            // loaiGDCmb
            // 
            this.loaiGDCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loaiGDCmb.FormattingEnabled = true;
            this.loaiGDCmb.Location = new System.Drawing.Point(298, 236);
            this.loaiGDCmb.Name = "loaiGDCmb";
            this.loaiGDCmb.Size = new System.Drawing.Size(217, 27);
            this.loaiGDCmb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại giao dịch";
            // 
            // tkCmb
            // 
            this.tkCmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uv_AccountDetailsBindingSource, "SOTK", true));
            this.tkCmb.FormattingEnabled = true;
            this.tkCmb.Location = new System.Drawing.Point(298, 102);
            this.tkCmb.Name = "tkCmb";
            this.tkCmb.Size = new System.Drawing.Size(217, 27);
            this.tkCmb.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tài khoản";
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
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(298, 187);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Properties.EditFormat.FormatString = "n0";
            this.txtSoTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTien.Size = new System.Drawing.Size(217, 28);
            this.txtSoTien.TabIndex = 10;
            // 
            // txtSoDu
            // 
            this.txtSoDu.Location = new System.Drawing.Point(298, 145);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(217, 28);
            this.txtSoDu.TabIndex = 11;
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
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).EndInit();
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
        private System.Windows.Forms.ComboBox tkCmb;
        private System.Windows.Forms.ComboBox loaiGDCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuiRut;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private DevExpress.XtraEditors.TextEdit txtSoDu;
    }
}