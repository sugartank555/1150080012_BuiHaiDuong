using System;
using System.Windows.Forms;

namespace _1150080012_BuiHaiDuong
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            txtSo.Focus();
            UpdateButtons();
        }

        // Chỉ cho nhập số nguyên (cho phép dấu âm ở đầu)
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                !(e.KeyChar == '-' && txtSo.SelectionStart == 0 && !txtSo.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }

        private void btnNhapSo_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtSo.Text.Trim(), out n))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.SelectAll(); txtSo.Focus();
                return;
            }

            lsbDaySo.Items.Add(n);
            txtSo.Clear();
            txtSo.Focus();
            UpdateButtons();
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lsbDaySo.Items[i]);
                lsbDaySo.Items[i] = val + 2;
            }
        }

        private void btnChonChanDau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lsbDaySo.Items[i]);
                if (val % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    lsbDaySo.TopIndex = i; // cuộn tới
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn trong dãy.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChonLeCuoi_Click(object sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                int val = Convert.ToInt32(lsbDaySo.Items[i]);
                if (val % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    lsbDaySo.TopIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số lẻ trong dãy.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            int idx = lsbDaySo.SelectedIndex;
            if (idx >= 0)
            {
                lsbDaySo.Items.RemoveAt(idx);
                UpdateButtons();
            }
            else
            {
                MessageBox.Show("Hãy chọn một phần tử để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                lsbDaySo.Items.RemoveAt(0);
                UpdateButtons();
            }
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
                UpdateButtons();
            }
        }

        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
            UpdateButtons();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có muốn kết thúc ứng dụng?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) Close();
        }

        private void UpdateButtons()
        {
            bool hasItems = lsbDaySo.Items.Count > 0;
            btnTang2.Enabled = hasItems;
            btnChonChanDau.Enabled = hasItems;
            btnChonLeCuoi.Enabled = hasItems;
            btnXoaDangChon.Enabled = hasItems;
            btnXoaDau.Enabled = hasItems;
            btnXoaCuoi.Enabled = hasItems;
            btnXoaDaySo.Enabled = hasItems;
        }

        private void lsbDaySo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXoaDangChon.Enabled = lsbDaySo.SelectedIndex >= 0;
        }
    }
}
