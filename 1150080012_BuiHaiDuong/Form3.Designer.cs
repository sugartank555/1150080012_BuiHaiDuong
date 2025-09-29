namespace _1150080012_BuiHaiDuong
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtDisplay;

        private System.Windows.Forms.GroupBox grpKeyboard;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnRing;

        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colGroup;
        private System.Windows.Forms.ColumnHeader colStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();

            this.grpKeyboard = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();

            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();

            this.grpLog = new System.Windows.Forms.GroupBox();
            this.lvLog = new System.Windows.Forms.ListView();
            this.colTime = new System.Windows.Forms.ColumnHeader();
            this.colGroup = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();

            this.panelTop.SuspendLayout();
            this.grpKeyboard.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();

            // panelTop (dải xám tiêu đề Password)
            this.panelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Controls.Add(this.lblPassword);
            this.panelTop.Controls.Add(this.txtDisplay);
            this.panelTop.Location = new System.Drawing.Point(12, 12);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(610, 52);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(12, 14);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 21);
            this.lblPassword.Text = "Password:";

            // txtDisplay
            this.txtDisplay.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular);
            this.txtDisplay.Location = new System.Drawing.Point(110, 12);
            this.txtDisplay.MaxLength = 4;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.PasswordChar = '●';
            this.txtDisplay.ReadOnly = true; // nhập qua keypad
            this.txtDisplay.Size = new System.Drawing.Size(360, 29);
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // grpKeyboard
            this.grpKeyboard.Controls.Add(this.btn1);
            this.grpKeyboard.Controls.Add(this.btn2);
            this.grpKeyboard.Controls.Add(this.btn3);
            this.grpKeyboard.Controls.Add(this.btn4);
            this.grpKeyboard.Controls.Add(this.btn5);
            this.grpKeyboard.Controls.Add(this.btn6);
            this.grpKeyboard.Controls.Add(this.btn7);
            this.grpKeyboard.Controls.Add(this.btn8);
            this.grpKeyboard.Controls.Add(this.btn9);
            this.grpKeyboard.Controls.Add(this.btnClear);
            this.grpKeyboard.Controls.Add(this.btnEnter);
            this.grpKeyboard.Controls.Add(this.btnRing);
            this.grpKeyboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpKeyboard.Location = new System.Drawing.Point(12, 74);
            this.grpKeyboard.Name = "grpKeyboard";
            this.grpKeyboard.Size = new System.Drawing.Size(610, 180);
            this.grpKeyboard.TabStop = true;
            this.grpKeyboard.Text = "Keyboard:";

            // Common for numeric buttons
            System.Drawing.Size numSize = new System.Drawing.Size(60, 40);
            System.Drawing.Font numFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            // btn1..btn9 (lưới 3x3)
            this.btn1.Location = new System.Drawing.Point(120, 30);
            this.btn1.Name = "btn1";
            this.btn1.Size = numSize;
            this.btn1.Font = numFont;
            this.btn1.Text = "1";
            this.btn1.Tag = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Digit_Click);

            this.btn2.Location = new System.Drawing.Point(190, 30);
            this.btn2.Name = "btn2";
            this.btn2.Size = numSize;
            this.btn2.Font = numFont;
            this.btn2.Text = "2";
            this.btn2.Tag = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Digit_Click);

            this.btn3.Location = new System.Drawing.Point(260, 30);
            this.btn3.Name = "btn3";
            this.btn3.Size = numSize;
            this.btn3.Font = numFont;
            this.btn3.Text = "3";
            this.btn3.Tag = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Digit_Click);

            this.btn4.Location = new System.Drawing.Point(120, 75);
            this.btn4.Name = "btn4";
            this.btn4.Size = numSize;
            this.btn4.Font = numFont;
            this.btn4.Text = "4";
            this.btn4.Tag = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Digit_Click);

            this.btn5.Location = new System.Drawing.Point(190, 75);
            this.btn5.Name = "btn5";
            this.btn5.Size = numSize;
            this.btn5.Font = numFont;
            this.btn5.Text = "5";
            this.btn5.Tag = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Digit_Click);

            this.btn6.Location = new System.Drawing.Point(260, 75);
            this.btn6.Name = "btn6";
            this.btn6.Size = numSize;
            this.btn6.Font = numFont;
            this.btn6.Text = "6";
            this.btn6.Tag = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Digit_Click);

            this.btn7.Location = new System.Drawing.Point(120, 120);
            this.btn7.Name = "btn7";
            this.btn7.Size = numSize;
            this.btn7.Font = numFont;
            this.btn7.Text = "7";
            this.btn7.Tag = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Digit_Click);

            this.btn8.Location = new System.Drawing.Point(190, 120);
            this.btn8.Name = "btn8";
            this.btn8.Size = numSize;
            this.btn8.Font = numFont;
            this.btn8.Text = "8";
            this.btn8.Tag = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Digit_Click);

            this.btn9.Location = new System.Drawing.Point(260, 120);
            this.btn9.Name = "btn9";
            this.btn9.Size = numSize;
            this.btn9.Font = numFont;
            this.btn9.Text = "9";
            this.btn9.Tag = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Digit_Click);

            // Cột phải: Clear (vàng), Enter (xanh), RING (đỏ)
            this.btnClear.Location = new System.Drawing.Point(380, 30);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.Text = "Clear";
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnEnter.Location = new System.Drawing.Point(380, 75);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 40);
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEnter.Text = "Enter";
            this.btnEnter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

            this.btnRing.Location = new System.Drawing.Point(380, 120);
            this.btnRing.Name = "btnRing";
            this.btnRing.Size = new System.Drawing.Size(100, 40);
            this.btnRing.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRing.Text = "RING";
            this.btnRing.BackColor = System.Drawing.Color.Red;
            this.btnRing.ForeColor = System.Drawing.Color.White;
            this.btnRing.UseVisualStyleBackColor = false;
            this.btnRing.Click += new System.EventHandler(this.btnRing_Click);

            // grpLog
            this.grpLog.Controls.Add(this.lvLog);
            this.grpLog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpLog.Location = new System.Drawing.Point(12, 264);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(610, 210);
            this.grpLog.TabStop = true;
            this.grpLog.Text = "Login Log:";

            // lvLog
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colTime, this.colGroup, this.colStatus
            });
            this.lvLog.FullRowSelect = true;
            this.lvLog.GridLines = true;
            this.lvLog.HideSelection = false;
            this.lvLog.Location = new System.Drawing.Point(10, 22);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(590, 180);
            this.lvLog.TabIndex = 0;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;

            this.colTime.Text = "Ngày giờ";
            this.colTime.Width = 190;
            this.colGroup.Text = "Nhóm";
            this.colGroup.Width = 260;
            this.colStatus.Text = "Kết quả";
            this.colStatus.Width = 120;

            // Form3
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 486);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpKeyboard);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Panel";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.grpKeyboard.ResumeLayout(false);
            this.grpLog.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
    }
}
