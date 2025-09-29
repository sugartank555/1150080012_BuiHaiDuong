namespace _1150080012_BuiHaiDuong
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ErrorProvider err;

        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.CheckBox chkLayCaoRang;
        private System.Windows.Forms.CheckBox chkTayTrangRang;
        private System.Windows.Forms.CheckBox chkHanRang;
        private System.Windows.Forms.CheckBox chkBeRang;
        private System.Windows.Forms.CheckBox chkBocRang;

        private System.Windows.Forms.Label lblGiaLayCao;
        private System.Windows.Forms.Label lblGiaTayTrang;
        private System.Windows.Forms.Label lblGiaHan;
        private System.Windows.Forms.Label lblGiaBe;
        private System.Windows.Forms.Label lblGiaBoc;

        private System.Windows.Forms.NumericUpDown nupHanRang;
        private System.Windows.Forms.NumericUpDown nupBeRang;
        private System.Windows.Forms.NumericUpDown nupBocRang;

        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;

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

            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);

            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.chkLayCaoRang = new System.Windows.Forms.CheckBox();
            this.chkTayTrangRang = new System.Windows.Forms.CheckBox();
            this.chkHanRang = new System.Windows.Forms.CheckBox();
            this.chkBeRang = new System.Windows.Forms.CheckBox();
            this.chkBocRang = new System.Windows.Forms.CheckBox();

            this.lblGiaLayCao = new System.Windows.Forms.Label();
            this.lblGiaTayTrang = new System.Windows.Forms.Label();
            this.lblGiaHan = new System.Windows.Forms.Label();
            this.lblGiaBe = new System.Windows.Forms.Label();
            this.lblGiaBoc = new System.Windows.Forms.Label();

            this.nupHanRang = new System.Windows.Forms.NumericUpDown();
            this.nupBeRang = new System.Windows.Forms.NumericUpDown();
            this.nupBocRang = new System.Windows.Forms.NumericUpDown();

            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.grpDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();

            // ===== Header xanh =====
            this.pnlHeader.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(700, 56);

            this.lblHeader.AutoSize = false;
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";

            // ===== Tên khách hàng =====
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(16, 70);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(95, 15);
            this.lblTenKH.Text = "Tên khách hàng:";

            this.txtTenKH.Location = new System.Drawing.Point(140, 66);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(420, 23);
            this.txtTenKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenKH_Validating);

            this.err.ContainerControl = this;

            // ===== Group Dịch vụ =====
            this.grpDichVu.Text = "Dịch vụ tại phòng khám:";
            this.grpDichVu.Location = new System.Drawing.Point(12, 100);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new System.Drawing.Size(670, 180);

            // Cột trái: checkbox
            this.chkLayCaoRang.AutoSize = true;
            this.chkLayCaoRang.Location = new System.Drawing.Point(20, 32);
            this.chkLayCaoRang.Name = "chkLayCaoRang";
            this.chkLayCaoRang.Text = "Lấy cao răng";

            this.chkTayTrangRang.AutoSize = true;
            this.chkTayTrangRang.Location = new System.Drawing.Point(20, 60);
            this.chkTayTrangRang.Name = "chkTayTrangRang";
            this.chkTayTrangRang.Text = "Tẩy trắng răng";

            this.chkHanRang.AutoSize = true;
            this.chkHanRang.Location = new System.Drawing.Point(20, 88);
            this.chkHanRang.Name = "chkHanRang";
            this.chkHanRang.Text = "Hàn răng";
            this.chkHanRang.CheckedChanged += new System.EventHandler(this.chkHanRang_CheckedChanged);

            this.chkBeRang.AutoSize = true;
            this.chkBeRang.Location = new System.Drawing.Point(20, 116);
            this.chkBeRang.Name = "chkBeRang";
            this.chkBeRang.Text = "Bẻ răng";
            this.chkBeRang.CheckedChanged += new System.EventHandler(this.chkBeRang_CheckedChanged);

            this.chkBocRang.AutoSize = true;
            this.chkBocRang.Location = new System.Drawing.Point(20, 144);
            this.chkBocRang.Name = "chkBocRang";
            this.chkBocRang.Text = "Bọc răng";
            this.chkBocRang.CheckedChanged += new System.EventHandler(this.chkBocRang_CheckedChanged);

            // Cột giữa: giá
            this.lblGiaLayCao.AutoSize = true;
            this.lblGiaLayCao.Location = new System.Drawing.Point(190, 33);
            this.lblGiaLayCao.Text = "50.000đ/2 hàm";

            this.lblGiaTayTrang.AutoSize = true;
            this.lblGiaTayTrang.Location = new System.Drawing.Point(190, 61);
            this.lblGiaTayTrang.Text = "100.000đ/2 hàm";

            this.lblGiaHan.AutoSize = true;
            this.lblGiaHan.Location = new System.Drawing.Point(190, 89);
            this.lblGiaHan.Text = "100.000đ/1 răng";

            this.lblGiaBe.AutoSize = true;
            this.lblGiaBe.Location = new System.Drawing.Point(190, 117);
            this.lblGiaBe.Text = "10.000đ/1 răng";

            this.lblGiaBoc.AutoSize = true;
            this.lblGiaBoc.Location = new System.Drawing.Point(190, 145);
            this.lblGiaBoc.Text = "1.000.000đ/1 răng";

            // Cột phải: NumericUpDown
            this.nupHanRang.Location = new System.Drawing.Point(320, 86);
            this.nupHanRang.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nupHanRang.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nupHanRang.Size = new System.Drawing.Size(60, 23);
            this.nupHanRang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupHanRang.Value = new decimal(new int[] { 1, 0, 0, 0 });

            this.nupBeRang.Location = new System.Drawing.Point(320, 114);
            this.nupBeRang.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nupBeRang.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nupBeRang.Size = new System.Drawing.Size(60, 23);
            this.nupBeRang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupBeRang.Value = new decimal(new int[] { 1, 0, 0, 0 });

            this.nupBocRang.Location = new System.Drawing.Point(320, 142);
            this.nupBocRang.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nupBocRang.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nupBocRang.Size = new System.Drawing.Size(60, 23);
            this.nupBocRang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupBocRang.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // Add controls vào grpDichVu
            this.grpDichVu.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.chkLayCaoRang, this.chkTayTrangRang, this.chkHanRang, this.chkBeRang, this.chkBocRang,
                this.lblGiaLayCao, this.lblGiaTayTrang, this.lblGiaHan, this.lblGiaBe, this.lblGiaBoc,
                this.nupHanRang, this.nupBeRang, this.nupBocRang
            });

            // ===== Group Chức năng =====
            this.grpChucNang.Text = "Chức năng:";
            this.grpChucNang.Location = new System.Drawing.Point(12, 286);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(670, 80);

            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTinhTien.Location = new System.Drawing.Point(140, 30);
            this.btnTinhTien.Size = new System.Drawing.Size(140, 32);
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThoat.Location = new System.Drawing.Point(380, 30);
            this.btnThoat.Size = new System.Drawing.Size(140, 32);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.grpChucNang.Controls.Add(this.btnTinhTien);
            this.grpChucNang.Controls.Add(this.btnThoat);

            // ===== Form4 =====
            this.AcceptButton = this.btnTinhTien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 381);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng khám nha khoa - Tính tiền";
            this.Load += new System.EventHandler(this.Form4_Load);

            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.grpDichVu.ResumeLayout(false);
            this.grpDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
