using Bai47_MDI.Services;

namespace Bai47_MDI.Forms;

public partial class FormMain : Form, IStatusMessenger
{
    public FormMain()
    {
        InitializeComponent();
        lblUser.Text = $"Người dùng: {AppSession.CurrentUser}";
        lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        clock.Start();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        btnStudent.Image = UiTheme.MakeIcon(Color.FromArgb(16, 124, 65), "SV");
        btnProduct.Image = UiTheme.MakeIcon(Color.FromArgb(0, 120, 215), "SP");
        btnRefresh.Image = UiTheme.MakeIcon(Color.FromArgb(136, 87, 0), "R");
        btnCascade.Image = UiTheme.MakeIcon(Color.FromArgb(98, 100, 167), "C");
        btnLogout.Image = UiTheme.MakeIcon(Color.FromArgb(196, 43, 28), "X");

        foreach (Control control in Controls)
        {
            if (control is MdiClient)
            {
                control.ContextMenuStrip = ctxMdi;
            }
        }

        ShowStatus("Sẵn sàng. Chọn chức năng từ thực đơn hoặc thanh công cụ.");
    }

    private void FormMain_Shown(object sender, EventArgs e)
    {
        ShowStatus("Sẵn sàng. Chọn chức năng từ thực đơn hoặc thanh công cụ.");
    }

    private void FormMain_MdiChildActivate(object sender, EventArgs e)
    {
        if (ActiveMdiChild is null)
        {
            ShowStatus("Không có cửa sổ con đang mở.");
            return;
        }

        ShowStatus($"Cửa sổ đang làm việc: {ActiveMdiChild.Text}");
    }

    private void clock_Tick(object sender, EventArgs e)
    {
        lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }

    /// <summary>
    /// Kiểm tra form con: chưa mở thì khởi tạo + Show; đã mở thì Activate, không nhân bản.
    /// </summary>
    public T OpenChild<T>() where T : Form, new()
    {
        foreach (Form child in MdiChildren)
        {
            if (child is T existing)
            {
                if (existing.WindowState == FormWindowState.Minimized)
                {
                    existing.WindowState = FormWindowState.Normal;
                }

                existing.Activate();
                existing.BringToFront();
                ShowStatus($"Kích hoạt cửa sổ: {existing.Text}");
                return existing;
            }
        }

        var form = new T { MdiParent = this };
        form.Show();
        ShowStatus($"Đã mở: {form.Text}");
        return form;
    }

    public void ShowStatus(string message)
    {
        lblMessage.Text = message;
        lblUser.Text = $"Người dùng: {AppSession.CurrentUser}";
    }

    public void RefreshActiveChild()
    {
        if (ActiveMdiChild is IRefreshableChild child)
        {
            child.RefreshData();
            ShowStatus($"Đã làm mới dữ liệu: {ActiveMdiChild.Text}");
            return;
        }

        ShowStatus("Không có cửa sổ con nào cần làm mới.");
    }

    private void mnuStudent_Click(object sender, EventArgs e) => OpenChild<FormStudent>();
    private void mnuProduct_Click(object sender, EventArgs e) => OpenChild<FormProduct>();
    private void mnuCascade_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);
    private void mnuTileH_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);
    private void mnuTileV_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);
    private void btnStudent_Click(object sender, EventArgs e) => OpenChild<FormStudent>();
    private void btnProduct_Click(object sender, EventArgs e) => OpenChild<FormProduct>();
    private void btnRefresh_Click(object sender, EventArgs e) => RefreshActiveChild();
    private void btnCascade_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);
    private void btnLogout_Click(object sender, EventArgs e) => Logout();
    private void mnuLogout_Click(object sender, EventArgs e) => Logout();
    private void mnuExit_Click(object sender, EventArgs e) => Close();

    private void Logout()
    {
        if (MessageBox.Show("Đăng xuất khỏi hệ thống?", "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        foreach (Form child in MdiChildren)
        {
            child.Close();
        }

        AppSession.CurrentUser = "Khách";
        AppSession.RequestRelogin = true;
        Close();
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        clock.Stop();
        if (AppSession.RequestRelogin)
        {
            return;
        }

        if (e.CloseReason == CloseReason.UserClosing)
        {
            var confirm = MessageBox.Show("Thoát ứng dụng?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                e.Cancel = true;
                clock.Start();
            }
        }
    }
}
