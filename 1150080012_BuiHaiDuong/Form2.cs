using System;
using System.Windows.Forms;

namespace _1150080012_BuiHaiDuong
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rdoUSCLN.Checked = true; // mặc định
            txtA.Focus();
        }

        // ====== Thuật toán ======
        private static long UCLN(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                long r = a % b;
                a = b;
                b = r;
            }
            return a; // nếu cả a=b=0 -> trả 0
        }

        private static long BSCNN(long a, long b)
        {
            if (a == 0 || b == 0) return 0; // quy ước: LCM(0, x) = 0
            long gcd = UCLN(a, b);
            // tránh tràn số: chia trước rồi nhân sau
            return Math.Abs((a / gcd) * b);
        }

        // Chỉ cho nhập số nguyên (kèm dấu âm ở đầu)
        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                !(e.KeyChar == '-' && txtA.SelectionStart == 0 && !txtA.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                !(e.KeyChar == '-' && txtB.SelectionStart == 0 && !txtB.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtA.Text.Trim(), out long a) ||
                !long.TryParse(txtB.Text.Trim(), out long b))
            {
                MessageBox.Show("Vui lòng nhập hai số nguyên hợp lệ.", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdoUSCLN.Checked)
            {
                long kq = UCLN(a, b);
                txtKetQua.Text = $"USCLN({a}, {b}) = {kq}";
            }
            else if (rdoBSCNN.Checked)
            {
                // nếu cả 2 đều 0, BSCNN = 0 theo quy ước
                long kq = BSCNN(a, b);
                txtKetQua.Text = $"BSCNN({a}, {b}) = {kq}";
            }
            else
            {
                MessageBox.Show("Hãy chọn USCLN hoặc BSCNN.", "Thiếu lựa chọn",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            rdoUSCLN.Checked = true;
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) Close();
        }

        // Giữ lại các handler cũ nếu đã được gắn trong project (không dùng cũng không sao)
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { } // không dùng
        private void button2_Click(object sender, EventArgs e) { } // không dùng
        private void button3_Click(object sender, EventArgs e) { } // không dùng
        private void button4_Click(object sender, EventArgs e) { } // không dùng
        private void button6_Click(object sender, EventArgs e) { } // không dùng
    }
}
