namespace Bai47_MDI.Forms;

partial class FormStudent
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlEditor;
    private Label lblMa;
    private Label lblTen;
    private Label lblNs;
    private Label lblGt;
    private Label lblLop;
    private Label lblEmail;
    private Label lblSdt;
    private TextBox txtMa;
    private TextBox txtTen;
    private DateTimePicker dtpNgaySinh;
    private ComboBox cboGt;
    private TextBox txtLop;
    private TextBox txtEmail;
    private TextBox txtSdt;
    private Button btnAdd;
    private Button btnEdit;
    private Button btnClear;
    private DataGridView dgvStudent;
    private ContextMenuStrip ctxGrid;
    private ToolStripMenuItem mnuDetail;
    private ToolStripMenuItem mnuRefresh;
    private ToolStripMenuItem mnuDelete;

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
        pnlEditor = new Panel();
        lblMa = new Label();
        txtMa = new TextBox();
        lblTen = new Label();
        txtTen = new TextBox();
        lblNs = new Label();
        dtpNgaySinh = new DateTimePicker();
        lblGt = new Label();
        cboGt = new ComboBox();
        lblLop = new Label();
        txtLop = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblSdt = new Label();
        txtSdt = new TextBox();
        btnAdd = new Button();
        btnEdit = new Button();
        btnClear = new Button();
        dgvStudent = new DataGridView();
        ctxGrid = new ContextMenuStrip(components);
        mnuDetail = new ToolStripMenuItem();
        mnuRefresh = new ToolStripMenuItem();
        mnuDelete = new ToolStripMenuItem();
        pnlEditor.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
        ctxGrid.SuspendLayout();
        SuspendLayout();

        pnlEditor.Controls.Add(btnClear);
        pnlEditor.Controls.Add(btnEdit);
        pnlEditor.Controls.Add(btnAdd);
        pnlEditor.Controls.Add(txtSdt);
        pnlEditor.Controls.Add(lblSdt);
        pnlEditor.Controls.Add(txtEmail);
        pnlEditor.Controls.Add(lblEmail);
        pnlEditor.Controls.Add(txtLop);
        pnlEditor.Controls.Add(lblLop);
        pnlEditor.Controls.Add(cboGt);
        pnlEditor.Controls.Add(lblGt);
        pnlEditor.Controls.Add(dtpNgaySinh);
        pnlEditor.Controls.Add(lblNs);
        pnlEditor.Controls.Add(txtTen);
        pnlEditor.Controls.Add(lblTen);
        pnlEditor.Controls.Add(txtMa);
        pnlEditor.Controls.Add(lblMa);
        pnlEditor.Dock = DockStyle.Top;
        pnlEditor.Location = new Point(0, 0);
        pnlEditor.Name = "pnlEditor";
        pnlEditor.Size = new Size(900, 150);

        lblMa.AutoSize = true;
        lblMa.Location = new Point(12, 8);
        lblMa.Text = "Mã SV";
        txtMa.Location = new Point(12, 28);
        txtMa.Name = "txtMa";
        txtMa.Size = new Size(120, 23);

        lblTen.AutoSize = true;
        lblTen.Location = new Point(150, 8);
        lblTen.Text = "Họ tên";
        txtTen.Location = new Point(150, 28);
        txtTen.Name = "txtTen";
        txtTen.Size = new Size(220, 23);

        lblNs.AutoSize = true;
        lblNs.Location = new Point(388, 8);
        lblNs.Text = "Ngày sinh";
        dtpNgaySinh.Format = DateTimePickerFormat.Short;
        dtpNgaySinh.Location = new Point(388, 28);
        dtpNgaySinh.Name = "dtpNgaySinh";
        dtpNgaySinh.Size = new Size(130, 23);

        lblGt.AutoSize = true;
        lblGt.Location = new Point(536, 8);
        lblGt.Text = "Giới tính";
        cboGt.DropDownStyle = ComboBoxStyle.DropDownList;
        cboGt.Items.AddRange(new object[] { "Nam", "Nữ" });
        cboGt.Location = new Point(536, 28);
        cboGt.Name = "cboGt";
        cboGt.Size = new Size(90, 23);
        cboGt.SelectedIndex = 0;

        lblLop.AutoSize = true;
        lblLop.Location = new Point(12, 70);
        lblLop.Text = "Lớp";
        txtLop.Location = new Point(12, 90);
        txtLop.Name = "txtLop";
        txtLop.Size = new Size(120, 23);

        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(150, 70);
        lblEmail.Text = "Email";
        txtEmail.Location = new Point(150, 90);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(220, 23);

        lblSdt.AutoSize = true;
        lblSdt.Location = new Point(388, 70);
        lblSdt.Text = "Điện thoại";
        txtSdt.Location = new Point(388, 90);
        txtSdt.Name = "txtSdt";
        txtSdt.Size = new Size(160, 23);

        btnAdd.Location = new Point(640, 24);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(84, 28);
        btnAdd.Text = "Thêm";
        btnAdd.Click += btnAdd_Click;

        btnEdit.Location = new Point(640, 58);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(84, 28);
        btnEdit.Text = "Sửa";
        btnEdit.Click += btnEdit_Click;

        btnClear.Location = new Point(730, 24);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(84, 28);
        btnClear.Text = "Nhập mới";
        btnClear.Click += btnClear_Click;

        ctxGrid.Items.AddRange(new ToolStripItem[] { mnuDetail, mnuRefresh, new ToolStripSeparator(), mnuDelete });
        ctxGrid.Name = "ctxGrid";

        mnuDetail.Name = "mnuDetail";
        mnuDetail.Text = "Xem chi tiết";
        mnuDetail.Click += mnuDetail_Click;

        mnuRefresh.Name = "mnuRefresh";
        mnuRefresh.Text = "Làm mới dữ liệu";
        mnuRefresh.Click += mnuRefresh_Click;

        mnuDelete.Name = "mnuDelete";
        mnuDelete.Text = "Xóa dòng";
        mnuDelete.Click += mnuDelete_Click;

        dgvStudent.AllowUserToAddRows = false;
        dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvStudent.BackgroundColor = Color.White;
        dgvStudent.ContextMenuStrip = ctxGrid;
        dgvStudent.Dock = DockStyle.Fill;
        dgvStudent.Location = new Point(0, 150);
        dgvStudent.MultiSelect = false;
        dgvStudent.Name = "dgvStudent";
        dgvStudent.ReadOnly = true;
        dgvStudent.RowHeadersVisible = false;
        dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvStudent.CellClick += dgvStudent_CellClick;
        dgvStudent.CellDoubleClick += dgvStudent_CellDoubleClick;
        dgvStudent.MouseDown += dgvStudent_MouseDown;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(900, 520);
        Controls.Add(dgvStudent);
        Controls.Add(pnlEditor);
        Name = "FormStudent";
        Text = "Quản lý Sinh viên";
        WindowState = FormWindowState.Maximized;

        pnlEditor.ResumeLayout(false);
        pnlEditor.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
        ctxGrid.ResumeLayout(false);
        ResumeLayout(false);
    }
}
