namespace Bai47_MDI.Forms;

partial class FormProduct
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlEditor;
    private Label lblMa;
    private Label lblTen;
    private Label lblGia;
    private Label lblSl;
    private Label lblDvt;
    private TextBox txtMa;
    private TextBox txtTen;
    private NumericUpDown numGia;
    private NumericUpDown numSl;
    private TextBox txtDvt;
    private Button btnAdd;
    private Button btnEdit;
    private Button btnClear;
    private DataGridView dgvProduct;
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
        lblGia = new Label();
        numGia = new NumericUpDown();
        lblSl = new Label();
        numSl = new NumericUpDown();
        lblDvt = new Label();
        txtDvt = new TextBox();
        btnAdd = new Button();
        btnEdit = new Button();
        btnClear = new Button();
        dgvProduct = new DataGridView();
        ctxGrid = new ContextMenuStrip(components);
        mnuDetail = new ToolStripMenuItem();
        mnuRefresh = new ToolStripMenuItem();
        mnuDelete = new ToolStripMenuItem();
        pnlEditor.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numGia).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSl).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
        ctxGrid.SuspendLayout();
        SuspendLayout();

        pnlEditor.Controls.Add(btnClear);
        pnlEditor.Controls.Add(btnEdit);
        pnlEditor.Controls.Add(btnAdd);
        pnlEditor.Controls.Add(txtDvt);
        pnlEditor.Controls.Add(lblDvt);
        pnlEditor.Controls.Add(numSl);
        pnlEditor.Controls.Add(lblSl);
        pnlEditor.Controls.Add(numGia);
        pnlEditor.Controls.Add(lblGia);
        pnlEditor.Controls.Add(txtTen);
        pnlEditor.Controls.Add(lblTen);
        pnlEditor.Controls.Add(txtMa);
        pnlEditor.Controls.Add(lblMa);
        pnlEditor.Dock = DockStyle.Top;
        pnlEditor.Location = new Point(0, 0);
        pnlEditor.Name = "pnlEditor";
        pnlEditor.Size = new Size(900, 120);

        lblMa.AutoSize = true;
        lblMa.Location = new Point(12, 8);
        lblMa.Text = "Mã SP";
        txtMa.Location = new Point(12, 28);
        txtMa.Name = "txtMa";
        txtMa.Size = new Size(120, 23);

        lblTen.AutoSize = true;
        lblTen.Location = new Point(150, 8);
        lblTen.Text = "Tên sản phẩm";
        txtTen.Location = new Point(150, 28);
        txtTen.Name = "txtTen";
        txtTen.Size = new Size(260, 23);

        lblGia.AutoSize = true;
        lblGia.Location = new Point(428, 8);
        lblGia.Text = "Đơn giá";
        numGia.Location = new Point(428, 28);
        numGia.Maximum = 100000000;
        numGia.Name = "numGia";
        numGia.Size = new Size(140, 23);
        numGia.ThousandsSeparator = true;

        lblSl.AutoSize = true;
        lblSl.Location = new Point(12, 58);
        lblSl.Text = "Số lượng";
        numSl.Location = new Point(12, 78);
        numSl.Maximum = 100000;
        numSl.Name = "numSl";
        numSl.Size = new Size(120, 23);

        lblDvt.AutoSize = true;
        lblDvt.Location = new Point(150, 58);
        lblDvt.Text = "Đơn vị tính";
        txtDvt.Location = new Point(150, 78);
        txtDvt.Name = "txtDvt";
        txtDvt.Size = new Size(140, 23);
        txtDvt.Text = "Cái";

        btnAdd.Location = new Point(428, 74);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(84, 28);
        btnAdd.Text = "Thêm";
        btnAdd.Click += btnAdd_Click;

        btnEdit.Location = new Point(520, 74);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(84, 28);
        btnEdit.Text = "Sửa";
        btnEdit.Click += btnEdit_Click;

        btnClear.Location = new Point(612, 74);
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

        dgvProduct.AllowUserToAddRows = false;
        dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProduct.BackgroundColor = Color.White;
        dgvProduct.ContextMenuStrip = ctxGrid;
        dgvProduct.Dock = DockStyle.Fill;
        dgvProduct.MultiSelect = false;
        dgvProduct.Name = "dgvProduct";
        dgvProduct.ReadOnly = true;
        dgvProduct.RowHeadersVisible = false;
        dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProduct.CellClick += dgvProduct_CellClick;
        dgvProduct.CellDoubleClick += dgvProduct_CellDoubleClick;
        dgvProduct.MouseDown += dgvProduct_MouseDown;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(900, 520);
        Controls.Add(dgvProduct);
        Controls.Add(pnlEditor);
        Name = "FormProduct";
        Text = "Quản lý Sản phẩm";
        WindowState = FormWindowState.Maximized;

        pnlEditor.ResumeLayout(false);
        pnlEditor.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numGia).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSl).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
        ctxGrid.ResumeLayout(false);
        ResumeLayout(false);
    }
}
