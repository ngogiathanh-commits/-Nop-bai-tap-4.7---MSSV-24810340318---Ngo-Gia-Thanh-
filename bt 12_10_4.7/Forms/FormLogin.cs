using Bai47_MDI.Services;

namespace Bai47_MDI.Forms;

public partial class FormLogin : Form
{
    public FormLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUser.Text.Trim().Equals("admin", StringComparison.OrdinalIgnoreCase) && txtPass.Text == "123")
        {
            AppSession.CurrentUser = txtUser.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        MessageBox.Show("Sai tài khoản hoặc mật khẩu.\nTài khoản mẫu: admin / 123", "Đăng nhập thất bại",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtPass.SelectAll();
        txtPass.Focus();
    }
}
