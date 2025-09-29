using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _1150080012_BuiHaiDuong
{
    public partial class Form3 : Form
    {
        // Map mật khẩu -> tên nhóm (C# 7.3)
        private readonly Dictionary<string, string> _passToGroup =
            new Dictionary<string, string>
            {
                { "1496", "Phát triển công nghệ" },
                { "2673", "Phát triển công nghệ" },
                { "7462", "Nghiên cứu viên" },
                { "8884", "Thiết kế mô hình" },
                { "3842", "Thiết kế mô hình" },
                { "3383", "Thiết kế mô hình" },
            };

        public Form3()
        {
            InitializeComponent();
            KeyPreview = true; // bắt phím từ bàn phím máy
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Focus();
        }

        // Nhập số từ bàn phím máy
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift)
            {
                int d = e.KeyCode - Keys.D0;
                AppendDigit(d.ToString());
                e.Handled = true;
                return;
            }

            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                int d = e.KeyCode - Keys.NumPad0;
                AppendDigit(d.ToString());
                e.Handled = true;
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                ValidateCode();
                e.Handled = true;
                return;
            }

            if (e.KeyCode == Keys.Back)
            {
                Backspace();
                e.Handled = true;
                return;
            }
        }

        // Nút số trên keypad UI (dùng chung)
        private void Digit_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b != null && b.Tag is string)
                AppendDigit((string)b.Tag);
        }

        private void AppendDigit(string d)
        {
            if (txtDisplay.Text.Length >= 4) return;
            txtDisplay.Text += d;
            if (txtDisplay.Text.Length == 4)
                ValidateCode(); // đủ 4 số thì tự xác thực
        }

        private void Backspace()
        {
            if (txtDisplay.Text.Length == 0) return;
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            txtDisplay.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ValidateCode();
        }

        private void btnRing_Click(object sender, EventArgs e)
        {
            // Chuông cảnh báo + log sự kiện
            System.Media.SystemSounds.Exclamation.Play();
            string when = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            ListViewItem item = new ListViewItem(new[] { when, "—", "RING" });
            item.BackColor = System.Drawing.Color.FromArgb(255, 249, 196); // vàng nhạt
            lvLog.Items.Insert(0, item);
        }

        // Xác thực mã
        private void ValidateCode()
        {
            string code = txtDisplay.Text.Trim();
            if (code.Length == 0) { txtDisplay.Focus(); return; }
            if (code.Length < 4)
            {
                MessageBox.Show("Mã gồm 4 chữ số. Vui lòng nhập đủ.", "Thiếu mã",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDisplay.Focus();
                return;
            }

            string group;
            string status;
            if (_passToGroup.TryGetValue(code, out group))
                status = "Chấp nhận!";
            else
            {
                status = "Từ chối!";
                group = "Không có";
            }

            string when = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            ListViewItem item = new ListViewItem(new[] { when, group, status });
            if (status.StartsWith("Chấp")) // xanh nhạt nếu OK
                item.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            else // đỏ nhạt nếu từ chối
                item.BackColor = System.Drawing.Color.FromArgb(255, 235, 238);

            lvLog.Items.Insert(0, item);
            txtDisplay.Clear();
            txtDisplay.Focus();
        }
    }
}
