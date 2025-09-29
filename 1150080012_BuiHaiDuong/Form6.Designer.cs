namespace _1150080012_BuiHaiDuong
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnNhapSo;

        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnChonChanDau;
        private System.Windows.Forms.Button btnChonLeCuoi;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaCuoi;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnXoaDaySo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnNhapSo = new System.Windows.Forms.Button();

            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChonChanDau = new System.Windows.Forms.Button();
            this.btnChonLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();

            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnXoaDaySo = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();

            // ===== Header (xanh ngọc) =====
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 150, 136); // teal
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 56;

            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Text = "Ứng dụng xử lý dãy số";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;

            // ===== Ô nhập số + nút =====
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Location = new System.Drawing.Point(16, 70);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(88, 15);
            this.lblNhapSo.Text = "Nhập số nguyên:";

            this.txtSo.Location = new System.Drawing.Point(120, 66);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(180, 23);
            this.txtSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo_KeyPress);

            this.btnNhapSo.Location = new System.Drawing.Point(320, 64);
            this.btnNhapSo.Name = "btnNhapSo";
            this.btnNhapSo.Size = new System.Drawing.Size(110, 28);
            this.btnNhapSo.Text = "Nhập số";
            this.btnNhapSo.UseVisualStyleBackColor = true;
            this.btnNhapSo.Click += new System.EventHandler(this.btnNhapSo_Click);

            // ===== ListBox bên trái =====
            this.lsbDaySo.Location = new System.Drawing.Point(12, 100);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new System.Drawing.Size(300, 290);
            this.lsbDaySo.SelectedIndexChanged += new System.EventHandler(this.lsbDaySo_SelectedIndexChanged);

            // ===== Group Chức năng bên phải =====
            this.grpChucNang.Text = "Chức năng:";
            this.grpChucNang.Location = new System.Drawing.Point(330, 100);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(220, 290);

            // Buttons trong group (xếp dọc)
            int x = 18, w = 184, h = 34, y = 28, gap = 12;

            this.btnTang2.Location = new System.Drawing.Point(x, y);
            this.btnTang2.Size = new System.Drawing.Size(w, h);
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);

            y += h + gap;
            this.btnChonChanDau.Location = new System.Drawing.Point(x, y);
            this.btnChonChanDau.Size = new System.Drawing.Size(w, h);
            this.btnChonChanDau.Text = "Chọn số chẵn đầu";
            this.btnChonChanDau.UseVisualStyleBackColor = true;
            this.btnChonChanDau.Click += new System.EventHandler(this.btnChonChanDau_Click);

            y += h + gap;
            this.btnChonLeCuoi.Location = new System.Drawing.Point(x, y);
            this.btnChonLeCuoi.Size = new System.Drawing.Size(w, h);
            this.btnChonLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnChonLeCuoi.UseVisualStyleBackColor = true;
            this.btnChonLeCuoi.Click += new System.EventHandler(this.btnChonLeCuoi_Click);

            y += h + gap;
            this.btnXoaDangChon.Location = new System.Drawing.Point(x, y);
            this.btnXoaDangChon.Size = new System.Drawing.Size(w, h);
            this.btnXoaDangChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);

            y += h + gap;
            this.btnXoaDau.Location = new System.Drawing.Point(x, y);
            this.btnXoaDau.Size = new System.Drawing.Size(w, h);
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.UseVisualStyleBackColor = true;
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);

            y += h + gap;
            this.btnXoaCuoi.Location = new System.Drawing.Point(x, y);
            this.btnXoaCuoi.Size = new System.Drawing.Size(w, h);
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.UseVisualStyleBackColor = true;
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);

            this.grpChucNang.Controls.Add(this.btnTang2);
            this.grpChucNang.Controls.Add(this.btnChonChanDau);
            this.grpChucNang.Controls.Add(this.btnChonLeCuoi);
            this.grpChucNang.Controls.Add(this.btnXoaDangChon);
            this.grpChucNang.Controls.Add(this.btnXoaDau);
            this.grpChucNang.Controls.Add(this.btnXoaCuoi);

            // ===== Bottom panel (2 nút lớn) =====
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Height = 56;
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;

            this.btnKetThuc.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnKetThuc.ForeColor = System.Drawing.Color.White;
            this.btnKetThuc.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnKetThuc.Location = new System.Drawing.Point(12, 10);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(170, 36);
            this.btnKetThuc.Text = "Kết thúc ứng dụng";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);

            this.btnXoaDaySo.BackColor = System.Drawing.Color.DimGray;
            this.btnXoaDaySo.ForeColor = System.Drawing.Color.White;
            this.btnXoaDaySo.Location = new System.Drawing.Point(380, 10);
            this.btnXoaDaySo.Name = "btnXoaDaySo";
            this.btnXoaDaySo.Size = new System.Drawing.Size(170, 36);
            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.UseVisualStyleBackColor = false;
            this.btnXoaDaySo.Click += new System.EventHandler(this.btnXoaDaySo_Click);

            this.pnlBottom.Controls.Add(this.btnKetThuc);
            this.pnlBottom.Controls.Add(this.btnXoaDaySo);

            // ===== Form6 =====
            this.AcceptButton = this.btnNhapSo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 460);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.btnNhapSo);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lý dãy số";
            this.Load += new System.EventHandler(this.Form6_Load);

            this.pnlHeader.ResumeLayout(false);
            this.grpChucNang.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
