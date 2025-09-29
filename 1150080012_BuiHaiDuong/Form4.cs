using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace _1150080012_BuiHaiDuong
{
    public partial class Form4 : Form
    {
        // Đơn giá (VND)
        private const int GiaLayCaoRang = 50_000;     // /2 hàm
        private const int GiaTayTrangRang = 100_000;    // /2 hàm
        private const int GiaHanRang = 100_000;    // /1 răng
        private const int GiaBeRang = 10_000;     // /1 răng
        private const int GiaBocRang = 1_000_000;  // /1 răng

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Trạng thái ban đầu: nup chỉ bật khi được chọn
            nupHanRang.Enabled = chkHanRang.Checked;
            nupBeRang.Enabled = chkBeRang.Checked;
            nupBocRang.Enabled = chkBocRang.Checked;
            txtTenKH.Focus();
        }

        // Bắt buộc nhập tên khách hàng
        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                e.Cancel = true;
                err.SetError(txtTenKH, "Tên khách hàng không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenKH, null);
            }
        }

        private void chkHanRang_CheckedChanged(object sender, EventArgs e)
        {
            nupHanRang.Enabled = chkHanRang.Checked;
            if (!chkHanRang.Checked) nupHanRang.Value = 0;
            else if (nupHanRang.Value == 0) nupHanRang.Value = 1;
        }

        private void chkBeRang_CheckedChanged(object sender, EventArgs e)
        {
            nupBeRang.Enabled = chkBeRang.Checked;
            if (!chkBeRang.Checked) nupBeRang.Value = 0;
            else if (nupBeRang.Value == 0) nupBeRang.Value = 1;
        }

        private void chkBocRang_CheckedChanged(object sender, EventArgs e)
        {
            nupBocRang.Enabled = chkBocRang.Checked;
            if (!chkBocRang.Checked) nupBocRang.Value = 0;
            else if (nupBocRang.Value == 0) nupBocRang.Value = 1;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled)) return;

            decimal tong = 0;
            StringBuilder ct = new StringBuilder();

            if (chkLayCaoRang.Checked)
            {
                tong += GiaLayCaoRang;
                ct.AppendLine($"- Lấy cao răng: {GiaLayCaoRang:N0} đ");
            }
            if (chkTayTrangRang.Checked)
            {
                tong += GiaTayTrangRang;
                ct.AppendLine($"- Tẩy trắng răng: {GiaTayTrangRang:N0} đ");
            }
            if (chkHanRang.Checked && nupHanRang.Value > 0)
            {
                decimal t = nupHanRang.Value * GiaHanRang;
                tong += t;
                ct.AppendLine($"- Hàn răng x{nupHanRang.Value}: {t:N0} đ");
            }
            if (chkBeRang.Checked && nupBeRang.Value > 0)
            {
                decimal t = nupBeRang.Value * GiaBeRang;
                tong += t;
                ct.AppendLine($"- Bẻ răng x{nupBeRang.Value}: {t:N0} đ");
            }
            if (chkBocRang.Checked && nupBocRang.Value > 0)
            {
                decimal t = nupBocRang.Value * GiaBocRang;
                tong += t;
                ct.AppendLine($"- Bọc răng x{nupBocRang.Value}: {t:N0} đ");
            }

            if (ct.Length == 0) ct.AppendLine("- Chưa chọn dịch vụ nào.");

            MessageBox.Show(
                $"PHÒNG KHÁM NHA KHOA HẢI ÂU\n" +
                $"Khách hàng: {txtTenKH.Text.Trim()}\n\n" +
                $"Chi tiết:\n{ct}\n" +
                $"TỔNG TIỀN: {tong:N0} đ",
                "Hóa đơn tạm tính",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) Close();
        }
    }
}
