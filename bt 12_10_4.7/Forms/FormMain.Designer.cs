namespace Bai47_MDI.Forms;

partial class FormMain
{
    private System.ComponentModel.IContainer components = null;

    private MenuStrip menuStrip;
    private ToolStripMenuItem mnuHeThong;
    private ToolStripMenuItem mnuLogout;
    private ToolStripMenuItem mnuExit;
    private ToolStripMenuItem mnuDanhMuc;
    private ToolStripMenuItem mnuStudent;
    private ToolStripMenuItem mnuProduct;
    private ToolStripMenuItem mnuWindow;
    private ToolStripMenuItem mnuCascade;
    private ToolStripMenuItem mnuTileH;
    private ToolStripMenuItem mnuTileV;
    private ToolStrip toolStrip;
    private ToolStripButton btnStudent;
    private ToolStripButton btnProduct;
    private ToolStripButton btnRefresh;
    private ToolStripButton btnCascade;
    private ToolStripButton btnLogout;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel lblUser;
    private ToolStripStatusLabel lblMessage;
    private ToolStripStatusLabel lblTime;
    private ContextMenuStrip ctxMdi;
    private ToolStripMenuItem ctxStudent;
    private ToolStripMenuItem ctxProduct;
    private ToolStripMenuItem ctxCascade;
    private ToolStripMenuItem ctxTileH;
    private ToolStripMenuItem ctxTileV;
    private System.Windows.Forms.Timer clock;

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
        components = new System.ComponentModel.Container();
        menuStrip = new MenuStrip();
        mnuHeThong = new ToolStripMenuItem();
        mnuLogout = new ToolStripMenuItem();
        mnuExit = new ToolStripMenuItem();
        mnuDanhMuc = new ToolStripMenuItem();
        mnuStudent = new ToolStripMenuItem();
        mnuProduct = new ToolStripMenuItem();
        mnuWindow = new ToolStripMenuItem();
        mnuCascade = new ToolStripMenuItem();
        mnuTileH = new ToolStripMenuItem();
        mnuTileV = new ToolStripMenuItem();
        toolStrip = new ToolStrip();
        btnStudent = new ToolStripButton();
        btnProduct = new ToolStripButton();
        btnRefresh = new ToolStripButton();
        btnCascade = new ToolStripButton();
        btnLogout = new ToolStripButton();
        statusStrip = new StatusStrip();
        lblUser = new ToolStripStatusLabel();
        lblMessage = new ToolStripStatusLabel();
        lblTime = new ToolStripStatusLabel();
        ctxMdi = new ContextMenuStrip(components);
        ctxStudent = new ToolStripMenuItem();
        ctxProduct = new ToolStripMenuItem();
        ctxCascade = new ToolStripMenuItem();
        ctxTileH = new ToolStripMenuItem();
        ctxTileV = new ToolStripMenuItem();
        clock = new System.Windows.Forms.Timer(components);
        menuStrip.SuspendLayout();
        toolStrip.SuspendLayout();
        statusStrip.SuspendLayout();
        ctxMdi.SuspendLayout();
        SuspendLayout();

        // menuStrip
        menuStrip.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuDanhMuc, mnuWindow });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.MdiWindowListItem = mnuWindow;
        menuStrip.Size = new Size(1100, 24);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip";

        // mnuHeThong
        mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuLogout, new ToolStripSeparator(), mnuExit });
        mnuHeThong.Name = "mnuHeThong";
        mnuHeThong.Text = "Hệ thống";

        // mnuLogout
        mnuLogout.Name = "mnuLogout";
        mnuLogout.ShortcutKeys = Keys.Control | Keys.L;
        mnuLogout.Text = "Đăng xuất";
        mnuLogout.Click += mnuLogout_Click;

        // mnuExit
        mnuExit.Name = "mnuExit";
        mnuExit.Text = "Thoát";
        mnuExit.Click += mnuExit_Click;

        // mnuDanhMuc
        mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuStudent, mnuProduct });
        mnuDanhMuc.Name = "mnuDanhMuc";
        mnuDanhMuc.Text = "Danh mục";

        // mnuStudent
        mnuStudent.Name = "mnuStudent";
        mnuStudent.ShortcutKeys = Keys.Control | Keys.D1;
        mnuStudent.Text = "Quản lý Sinh viên";
        mnuStudent.Click += mnuStudent_Click;

        // mnuProduct
        mnuProduct.Name = "mnuProduct";
        mnuProduct.ShortcutKeys = Keys.Control | Keys.D2;
        mnuProduct.Text = "Quản lý Sản phẩm";
        mnuProduct.Click += mnuProduct_Click;

        // mnuWindow
        mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileH, mnuTileV, new ToolStripSeparator() });
        mnuWindow.Name = "mnuWindow";
        mnuWindow.Text = "Cửa sổ";

        // mnuCascade
        mnuCascade.Name = "mnuCascade";
        mnuCascade.Text = "Cascade";
        mnuCascade.Click += mnuCascade_Click;

        // mnuTileH
        mnuTileH.Name = "mnuTileH";
        mnuTileH.Text = "Tile Horizontal";
        mnuTileH.Click += mnuTileH_Click;

        // mnuTileV
        mnuTileV.Name = "mnuTileV";
        mnuTileV.Text = "Tile Vertical";
        mnuTileV.Click += mnuTileV_Click;

        // toolStrip
        toolStrip.GripStyle = ToolStripGripStyle.Hidden;
        toolStrip.ImageScalingSize = new Size(20, 20);
        toolStrip.Items.AddRange(new ToolStripItem[]
        {
            btnStudent, btnProduct, new ToolStripSeparator(),
            btnRefresh, btnCascade, new ToolStripSeparator(), btnLogout
        });
        toolStrip.Location = new Point(0, 24);
        toolStrip.Name = "toolStrip";
        toolStrip.Size = new Size(1100, 27);
        toolStrip.TabIndex = 1;

        // btnStudent
        btnStudent.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        btnStudent.Name = "btnStudent";
        btnStudent.Text = "Sinh viên";
        btnStudent.ToolTipText = "Mở quản lý sinh viên";
        btnStudent.Click += btnStudent_Click;

        // btnProduct
        btnProduct.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        btnProduct.Name = "btnProduct";
        btnProduct.Text = "Sản phẩm";
        btnProduct.ToolTipText = "Mở quản lý sản phẩm";
        btnProduct.Click += btnProduct_Click;

        // btnRefresh
        btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Text = "Làm mới";
        btnRefresh.ToolTipText = "Làm mới form con đang mở";
        btnRefresh.Click += btnRefresh_Click;

        // btnCascade
        btnCascade.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        btnCascade.Name = "btnCascade";
        btnCascade.Text = "Cascade";
        btnCascade.Click += btnCascade_Click;

        // btnLogout
        btnLogout.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        btnLogout.Name = "btnLogout";
        btnLogout.Text = "Đăng xuất";
        btnLogout.Click += btnLogout_Click;

        // statusStrip
        statusStrip.Items.AddRange(new ToolStripItem[] { lblUser, lblMessage, lblTime });
        statusStrip.Location = new Point(0, 628);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(1100, 22);
        statusStrip.SizingGrip = false;
        statusStrip.TabIndex = 2;

        // lblUser
        lblUser.BorderSides = ToolStripStatusLabelBorderSides.Right;
        lblUser.Name = "lblUser";
        lblUser.Text = "Người dùng: ";

        // lblMessage
        lblMessage.Name = "lblMessage";
        lblMessage.Spring = true;
        lblMessage.Text = "Sẵn sàng";
        lblMessage.TextAlign = ContentAlignment.MiddleLeft;

        // lblTime
        lblTime.BorderSides = ToolStripStatusLabelBorderSides.Left;
        lblTime.Name = "lblTime";
        lblTime.Text = "00:00:00";

        // ctxMdi
        ctxMdi.Items.AddRange(new ToolStripItem[]
        {
            ctxStudent, ctxProduct, new ToolStripSeparator(), ctxCascade, ctxTileH, ctxTileV
        });
        ctxMdi.Name = "ctxMdi";
        ctxMdi.Size = new Size(200, 120);

        ctxStudent.Name = "ctxStudent";
        ctxStudent.Text = "Quản lý Sinh viên";
        ctxStudent.Click += mnuStudent_Click;

        ctxProduct.Name = "ctxProduct";
        ctxProduct.Text = "Quản lý Sản phẩm";
        ctxProduct.Click += mnuProduct_Click;

        ctxCascade.Name = "ctxCascade";
        ctxCascade.Text = "Cascade";
        ctxCascade.Click += mnuCascade_Click;

        ctxTileH.Name = "ctxTileH";
        ctxTileH.Text = "Tile Horizontal";
        ctxTileH.Click += mnuTileH_Click;

        ctxTileV.Name = "ctxTileV";
        ctxTileV.Text = "Tile Vertical";
        ctxTileV.Click += mnuTileV_Click;

        // clock
        clock.Interval = 1000;
        clock.Tick += clock_Tick;

        // FormMain
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 650);
        Controls.Add(statusStrip);
        Controls.Add(toolStrip);
        Controls.Add(menuStrip);
        IsMdiContainer = true;
        MainMenuStrip = menuStrip;
        MinimumSize = new Size(900, 600);
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Hệ thống quản lý MDI - Bài 4.7";
        WindowState = FormWindowState.Maximized;
        Load += FormMain_Load;
        Shown += FormMain_Shown;
        MdiChildActivate += FormMain_MdiChildActivate;
        FormClosing += FormMain_FormClosing;

        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        toolStrip.ResumeLayout(false);
        toolStrip.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ctxMdi.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }
}
