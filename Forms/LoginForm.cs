using System.Diagnostics;
using System.Windows.Forms;

namespace chuyen_de_hoc_tap_doanh_nghiep_06
{
    public partial class LoginForm : Form
    {
        private const string VALID_ACCOUNT = "admin";

        private const string VALID_PASSWORD = "123456";

        private string account = string.Empty;

        private string password = string.Empty;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            accountTextBox.Text = VALID_ACCOUNT;

            passwordTextBox.Text = VALID_PASSWORD;

            rememberAccountCheckBox.Checked = true;

            Debug.WriteLine("Form loaded!");
        }

        private void AccountTextBox_TextChanged(object sender, System.EventArgs e)
        {
            account = accountTextBox.Text;
            Debug.WriteLine($"Account: {account}");
        }

        private void PasswordTextBox_TextChanged(object sender, System.EventArgs e)
        {
            password = passwordTextBox.Text;
            Debug.WriteLine($"Password: {password}");
        }

        private void RememberAccountCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"Remember this account: {rememberAccountCheckBox.Checked}");
        }

        private void ForgetPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Tài khoản: admin\nMật khẩu: 123456", "GỢI Ý THÔNG TIN TÀI KHOẢN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            if (account.Equals(VALID_ACCOUNT) && password.Equals(VALID_PASSWORD))
            {
                MessageBox.Show("Đăng nhập thành công!", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Đăng nhập thất bại!\nTên tài khoản hoặc mật khẩu không chính xác.\nXin vui lòng thử lại.", "THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Tính năng này hiện chưa có sẵn.", "CHƯA CÓ SẴN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}