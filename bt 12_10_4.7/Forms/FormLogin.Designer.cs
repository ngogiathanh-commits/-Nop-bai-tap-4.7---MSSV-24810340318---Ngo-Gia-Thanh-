namespace Bai47_MDI.Forms;

partial class FormLogin
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlHeader;
    private Label lblTitle;
    private Label lblUser;
    private Label lblPass;
    private TextBox txtUser;
    private TextBox txtPass;
    private Button btnLogin;
    private Button btnCancel;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlHeader = new Panel();
        lblTitle = new Label();
        lblUser = new Label();
        txtUser = new TextBox();
        lblPass = new Label();
        txtPass = new TextBox();
        btnLogin = new Button();
        btnCancel = new Button();
        pnlHeader.SuspendLayout();
        SuspendLayout();

        pnlHeader.BackColor = Color.FromArgb(25, 55, 95);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(420, 72);

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(24, 22);
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "QUẢN LÝ MDI";

        lblUser.AutoSize = true;
        lblUser.Location = new Point(40, 100);
        lblUser.Name = "lblUser";
        lblUser.Text = "Tên đăng nhập";

        txtUser.Location = new Point(40, 122);
        txtUser.Name = "txtUser";
        txtUser.Size = new Size(340, 23);
        txtUser.Text = "admin";

        lblPass.AutoSize = true;
        lblPass.Location = new Point(40, 158);
        lblPass.Name = "lblPass";
        lblPass.Text = "Mật khẩu";

        txtPass.Location = new Point(40, 180);
        txtPass.Name = "txtPass";
        txtPass.Size = new Size(340, 23);
        txtPass.UseSystemPasswordChar = true;
        txtPass.Text = "123";

        btnLogin.BackColor = Color.FromArgb(0, 120, 215);
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(180, 224);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(110, 32);
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;

        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.Location = new Point(300, 224);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(80, 32);
        btnCancel.Text = "Thoát";

        AcceptButton = btnLogin;
        CancelButton = btnCancel;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(420, 280);
        Controls.Add(btnCancel);
        Controls.Add(btnLogin);
        Controls.Add(txtPass);
        Controls.Add(lblPass);
        Controls.Add(txtUser);
        Controls.Add(lblUser);
        Controls.Add(pnlHeader);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đăng nhập hệ thống";

        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
