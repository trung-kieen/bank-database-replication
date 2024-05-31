namespace BankReplication.report
{
    partial class formTaoLogin
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
            this.btnDeleteLogin = new DevExpress.XtraEditors.SimpleButton();
            this.roleCmb = new System.Windows.Forms.ComboBox();
            this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.radioKhachHang = new System.Windows.Forms.RadioButton();
            this.radioNhanVien = new System.Windows.Forms.RadioButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtLoginName = new DevExpress.XtraEditors.TextEdit();
            this.tkCmb = new System.Windows.Forms.ComboBox();
            this.btnTaoLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.controlBtnChangePassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.controlBtnDelete = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.controlBtnLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbTaiKhoan = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Nhóm = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBtnChangePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBtnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nhóm)).BeginInit();
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
            this.cmbChiNhanh.Location = new System.Drawing.Point(130, 20);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(396, 27);
            this.cmbChiNhanh.TabIndex = 9;
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
            this.panelControl1.Location = new System.Drawing.Point(125, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(546, 538);
            this.panelControl1.TabIndex = 10;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDeleteLogin);
            this.layoutControl1.Controls.Add(this.roleCmb);
            this.layoutControl1.Controls.Add(this.btnChangePassword);
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Controls.Add(this.txtPassword);
            this.layoutControl1.Controls.Add(this.txtLoginName);
            this.layoutControl1.Controls.Add(this.tkCmb);
            this.layoutControl1.Controls.Add(this.btnTaoLogin);
            this.layoutControl1.Controls.Add(this.cmbChiNhanh);
            this.layoutControl1.Controls.Add(this.txtUserName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(802, 0, 975, 600);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(546, 538);
            this.layoutControl1.TabIndex = 11;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDeleteLogin
            // 
            this.btnDeleteLogin.Location = new System.Drawing.Point(275, 484);
            this.btnDeleteLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteLogin.Name = "btnDeleteLogin";
            this.btnDeleteLogin.Size = new System.Drawing.Size(259, 32);
            this.btnDeleteLogin.StyleController = this.layoutControl1;
            this.btnDeleteLogin.TabIndex = 20;
            this.btnDeleteLogin.Text = "Xóa tài khoản";
            // 
            // roleCmb
            // 
            this.roleCmb.DisplayMember = "Text";
            this.roleCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCmb.FormattingEnabled = true;
            this.roleCmb.Location = new System.Drawing.Point(132, 403);
            this.roleCmb.Margin = new System.Windows.Forms.Padding(4);
            this.roleCmb.Name = "roleCmb";
            this.roleCmb.Size = new System.Drawing.Size(392, 27);
            this.roleCmb.TabIndex = 19;
            this.roleCmb.ValueMember = "Value";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(12, 484);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(259, 32);
            this.btnChangePassword.StyleController = this.layoutControl1;
            this.btnChangePassword.TabIndex = 18;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radioKhachHang);
            this.groupControl1.Controls.Add(this.radioNhanVien);
            this.groupControl1.Location = new System.Drawing.Point(12, 63);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(5);
            this.groupControl1.Size = new System.Drawing.Size(522, 115);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Đối tượng";
            // 
            // radioKhachHang
            // 
            this.radioKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioKhachHang.Location = new System.Drawing.Point(7, 39);
            this.radioKhachHang.Name = "radioKhachHang";
            this.radioKhachHang.Size = new System.Drawing.Size(508, 29);
            this.radioKhachHang.TabIndex = 13;
            this.radioKhachHang.TabStop = true;
            this.radioKhachHang.Text = "Khách hàng";
            this.radioKhachHang.UseVisualStyleBackColor = true;
            this.radioKhachHang.CheckedChanged += new System.EventHandler(this.radio_SelectedChange);
            // 
            // radioNhanVien
            // 
            this.radioNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radioNhanVien.Location = new System.Drawing.Point(7, 71);
            this.radioNhanVien.Name = "radioNhanVien";
            this.radioNhanVien.Size = new System.Drawing.Size(508, 37);
            this.radioNhanVien.TabIndex = 12;
            this.radioNhanVien.TabStop = true;
            this.radioNhanVien.Text = "Nhân viên";
            this.radioNhanVien.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(132, 351);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(392, 28);
            this.txtPassword.StyleController = this.layoutControl1;
            this.txtPassword.TabIndex = 17;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(132, 299);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(392, 28);
            this.txtLoginName.StyleController = this.layoutControl1;
            this.txtLoginName.TabIndex = 16;
            // 
            // tkCmb
            // 
            this.tkCmb.DisplayMember = "TENCN";
            this.tkCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tkCmb.FormattingEnabled = true;
            this.tkCmb.Location = new System.Drawing.Point(132, 192);
            this.tkCmb.Margin = new System.Windows.Forms.Padding(4);
            this.tkCmb.Name = "tkCmb";
            this.tkCmb.Size = new System.Drawing.Size(392, 27);
            this.tkCmb.TabIndex = 14;
            this.tkCmb.SelectedIndexChanged += new System.EventHandler(this.tkCmb_SelectedIndexChanged);
            // 
            // btnTaoLogin
            // 
            this.btnTaoLogin.Location = new System.Drawing.Point(12, 448);
            this.btnTaoLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnTaoLogin.Name = "btnTaoLogin";
            this.btnTaoLogin.Size = new System.Drawing.Size(522, 32);
            this.btnTaoLogin.StyleController = this.layoutControl1;
            this.btnTaoLogin.TabIndex = 10;
            this.btnTaoLogin.Text = "Tạo tài khoản";
            this.btnTaoLogin.Click += new System.EventHandler(this.btnTaoLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(132, 247);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(392, 28);
            this.txtUserName.StyleController = this.layoutControl1;
            this.txtUserName.TabIndex = 15;
            // 
            // controlBtnChangePassword
            // 
            this.controlBtnChangePassword.Control = this.btnChangePassword;
            this.controlBtnChangePassword.Location = new System.Drawing.Point(0, 472);
            this.controlBtnChangePassword.Name = "controlBtnChangePassword";
            this.controlBtnChangePassword.Size = new System.Drawing.Size(263, 36);
            this.controlBtnChangePassword.TextSize = new System.Drawing.Size(0, 0);
            this.controlBtnChangePassword.TextVisible = false;
            // 
            // controlBtnDelete
            // 
            this.controlBtnDelete.Control = this.btnDeleteLogin;
            this.controlBtnDelete.Location = new System.Drawing.Point(263, 472);
            this.controlBtnDelete.Name = "controlBtnDelete";
            this.controlBtnDelete.Size = new System.Drawing.Size(263, 36);
            this.controlBtnDelete.TextSize = new System.Drawing.Size(0, 0);
            this.controlBtnDelete.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.controlBtnLogin,
            this.lbTaiKhoan,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.Nhóm,
            this.controlBtnChangePassword,
            this.controlBtnDelete});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(546, 538);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbChiNhanh;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "controlCmbChiNhanh";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(526, 51);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Text = "Chi Nhánh";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(107, 19);
            // 
            // controlBtnLogin
            // 
            this.controlBtnLogin.Control = this.btnTaoLogin;
            this.controlBtnLogin.Location = new System.Drawing.Point(0, 436);
            this.controlBtnLogin.Name = "controlBtnLogin";
            this.controlBtnLogin.Size = new System.Drawing.Size(526, 36);
            this.controlBtnLogin.TextSize = new System.Drawing.Size(0, 0);
            this.controlBtnLogin.TextVisible = false;
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.Control = this.tkCmb;
            this.lbTaiKhoan.Location = new System.Drawing.Point(0, 170);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(526, 55);
            this.lbTaiKhoan.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.lbTaiKhoan.Text = "Tài khoản";
            this.lbTaiKhoan.TextSize = new System.Drawing.Size(107, 19);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtUserName;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 225);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(526, 52);
            this.layoutControlItem6.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem6.Text = "Mã người dùng";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(107, 19);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtLoginName;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 277);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(526, 52);
            this.layoutControlItem7.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem7.Text = "Tên đăng nhập";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(107, 19);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtPassword;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 329);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(526, 52);
            this.layoutControlItem8.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem8.Text = "Mật khẩu";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(107, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.groupControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 51);
            this.layoutControlItem3.Name = "controlRolePicker";
            this.layoutControlItem3.Size = new System.Drawing.Size(526, 119);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 508);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(526, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Nhóm
            // 
            this.Nhóm.Control = this.roleCmb;
            this.Nhóm.Location = new System.Drawing.Point(0, 381);
            this.Nhóm.Name = "Nhóm";
            this.Nhóm.Size = new System.Drawing.Size(526, 55);
            this.Nhóm.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.Nhóm.TextSize = new System.Drawing.Size(107, 19);
            // 
            // formTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 553);
            this.Controls.Add(this.panelContainer);
            this.Name = "formTaoLogin";
            this.Text = "Tạo tài khoản đăng nhập";
            this.Load += new System.EventHandler(this.thongKeKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv_AccountDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).EndInit();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBtnChangePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBtnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nhóm)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnTaoLogin;
        private DevExpress.XtraLayout.LayoutControlItem controlBtnLogin;
        private System.Windows.Forms.RadioButton radioKhachHang;
        private System.Windows.Forms.RadioButton radioNhanVien;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtLoginName;
        private System.Windows.Forms.ComboBox tkCmb;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraLayout.LayoutControlItem lbTaiKhoan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
        private DevExpress.XtraLayout.LayoutControlItem controlBtnChangePassword;
        private System.Windows.Forms.ComboBox roleCmb;
        private DevExpress.XtraLayout.LayoutControlItem Nhóm;
        private DevExpress.XtraEditors.SimpleButton btnDeleteLogin;
        private DevExpress.XtraLayout.LayoutControlItem controlBtnDelete;
    }
}