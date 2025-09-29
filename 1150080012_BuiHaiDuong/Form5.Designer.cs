namespace _1150080012_BuiHaiDuong
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox chkShowPass;

        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.ErrorProvider err;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();

            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.chkShowPass = new System.Windows.Forms.CheckBox();

            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.err = new System.Windows.Forms.ErrorProvider(this.components);

            this.pnlHeader.SuspendLayout();
            this.grpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();

            // ===== Header =====
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(460, 54);

            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.Text = "ĐĂNG NHẬP HỆ THỐNG";

            // ===== Username =====
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(28, 72);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 15);
            this.lblUser.Text = "Username:";

            this.txtUser.Location = new System.Drawing.Point(120, 68);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(300, 23);
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_Validating);

            // ===== Password =====
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(28, 106);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 15);
            this.lblPass.Text = "Password:";

            this.txtPass.Location = new System.Drawing.Point(120, 102);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(300, 23);
            this.txtPass.PasswordChar = '●';
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);

            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Location = new System.Drawing.Point(120, 131);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(104, 19);
            this.chkShowPass.Text = "Hiện mật khẩu";
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);

            // ===== Buttons =====
            this.grpButtons.Text = "Chức năng";
            this.grpButtons.Location = new System.Drawing.Point(20, 165);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(420, 70);

            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogin.Location = new System.Drawing.Point(24, 26);
            this.btnLogin.Size = new System.Drawing.Size(110, 32);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.btnClear.Text = "Xóa";
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.Location = new System.Drawing.Point(162, 26);
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnExit.Text = "Thoát";
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit.Location = new System.Drawing.Point(278, 26);
            this.btnExit.Size = new System.Drawing.Size(110, 32);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.grpButtons.Controls.Add(this.btnLogin);
            this.grpButtons.Controls.Add(this.btnClear);
            this.grpButtons.Controls.Add(this.btnExit);

            // ErrorProvider
            this.err.ContainerControl = this;

            // ===== Form5 =====
            this.AcceptButton = this.btnLogin;
            this.CancelButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 248);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form5_Load);

            this.pnlHeader.ResumeLayout(false);
            this.grpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
