namespace BankReplication.form
{
    public partial class formDangNhap
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
            this.txtPassword = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.inputTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.NGANHANGDATASET = new BankReplication.NGANHANGDataSet();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.uvGetSubcribersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDangNhap = new DevExpress.XtraEditors.CheckButton();
            this.btnThoat = new DevExpress.XtraEditors.CheckButton();
            this.panelContainer = new DevExpress.XtraEditors.PanelControl();
            this.uv_GetSubcribersTableAdapter = new BankReplication.NGANHANGDataSetTableAdapters.uv_GetSubcribersTableAdapter();
            this.uvGetSubcribersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NGANHANGDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvGetSubcribersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uvGetSubcribersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(64, 19);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "Mật khẩu";
            this.txtPassword.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.inputPassword);
            this.panelControl1.Controls.Add(this.txtPassword);
            this.panelControl1.Location = new System.Drawing.Point(41, 162);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(425, 35);
            this.panelControl1.TabIndex = 3;
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(96, 3);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Size = new System.Drawing.Size(329, 27);
            this.inputPassword.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.inputTaiKhoan);
            this.panelControl2.Controls.Add(this.txtTaiKhoan);
            this.panelControl2.Location = new System.Drawing.Point(41, 102);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(425, 35);
            this.panelControl2.TabIndex = 2;
            // 
            // inputTaiKhoan
            // 
            this.inputTaiKhoan.Location = new System.Drawing.Point(96, 2);
            this.inputTaiKhoan.Name = "inputTaiKhoan";
            this.inputTaiKhoan.Size = new System.Drawing.Size(329, 28);
            this.inputTaiKhoan.TabIndex = 2;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(5, 5);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(70, 19);
            this.txtTaiKhoan.TabIndex = 0;
            this.txtTaiKhoan.Text = "Tài khoản";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.cmbChiNhanh);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Location = new System.Drawing.Point(41, 40);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(425, 35);
            this.panelControl3.TabIndex = 1;
            // 
            // cmbChiNhanh
            // 
            //            this.cmbChiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uvGetSubcribersBindingSource1, "TENCN", true));
            this.cmbChiNhanh.DataSource = this.uvGetSubcribersBindingSource;
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(96, 2);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(329, 27);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // NGANHANGDATASET
            // 
            this.NGANHANGDATASET.DataSetName = "NGANHANGDataSet";
            this.NGANHANGDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chi Nhánh";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(94, 237);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(136, 39);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.TabStop = false;
            this.btnDangNhap.Text = "Đăng nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(273, 237);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(136, 39);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.TabStop = false;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.CheckedChanged += new System.EventHandler(this.btnThoat_CheckedChanged);
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelContainer.Controls.Add(this.panelControl3);
            this.panelContainer.Controls.Add(this.btnThoat);
            this.panelContainer.Controls.Add(this.panelControl1);
            this.panelContainer.Controls.Add(this.btnDangNhap);
            this.panelContainer.Controls.Add(this.panelControl2);
            this.panelContainer.Location = new System.Drawing.Point(93, 101);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(529, 303);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl4_Paint);
            // 
            // uv_GetSubcribersTableAdapter
            // 
            this.uv_GetSubcribersTableAdapter.ClearBeforeFill = true;
            // 
            // uvGetSubcribersBindingSource1
            // 
            this.uvGetSubcribersBindingSource1.DataMember = "uv_GetSubcribers";
            this.uvGetSubcribersBindingSource1.DataSource = this.NGANHANGDATASET;
            // 
            // formDangNhap
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 497);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.fDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NGANHANGDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvGetSubcribersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).EndInit();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uvGetSubcribersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl txtPassword;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit inputTaiKhoan;
        private DevExpress.XtraEditors.LabelControl txtTaiKhoan;
        private System.Windows.Forms.TextBox inputPassword;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.CheckButton btnDangNhap;
        private DevExpress.XtraEditors.CheckButton btnThoat;
        private DevExpress.XtraEditors.PanelControl panelContainer;
        private NGANHANGDataSet NGANHANGDATASET;
        private System.Windows.Forms.BindingSource uvGetSubcribersBindingSource;
        private NGANHANGDataSetTableAdapters.uv_GetSubcribersTableAdapter uv_GetSubcribersTableAdapter;
        private System.Windows.Forms.BindingSource uvGetSubcribersBindingSource1;
    }
}