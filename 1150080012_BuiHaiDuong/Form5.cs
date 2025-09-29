using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace _1150080012_BuiHaiDuong
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        // Bắt buộc nhập Username
        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                e.Cancel = true;
                err.SetError(txtUser, "Không được để trống Username");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtUser, null);
            }
        }

        // Bắt buộc nhập Password
        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                e.Cancel = true;
                err.SetError(txtPass, "Không được để trống Password");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtPass, null);
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = chkShowPass.Checked ? '\0' : '●';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Chỉ yêu cầu KHÔNG để trống theo đề bài
            if (!ValidateChildren(ValidationConstraints.Enabled)) return;

            MessageBox.Show(
                "Đăng nhập thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Nếu muốn kiểm tra tài khoản cố định:
            // if (txtUser.Text == "admin" && txtPass.Text == "123")
            //   ... open next form ...
            // else MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            chkShowPass.Checked = false;
            txtUser.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) Close();
        }
    }
}
