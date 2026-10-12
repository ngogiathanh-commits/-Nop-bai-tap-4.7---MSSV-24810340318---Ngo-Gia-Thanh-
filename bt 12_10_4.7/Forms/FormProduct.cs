using Bai47_MDI.Data;
using Bai47_MDI.Models;
using Bai47_MDI.Services;

namespace Bai47_MDI.Forms;

public partial class FormProduct : Form, IRefreshableChild
{
    private readonly BindingSource _binding = new();

    public FormProduct()
    {
        InitializeComponent();
        dgvProduct.DataSource = _binding;
        Load += (_, _) => RefreshData();
    }

    public void RefreshData()
    {
        _binding.DataSource = ProductRepository.GetAll();
        if (dgvProduct.Columns.Count == 0)
        {
            return;
        }

        dgvProduct.Columns[nameof(Product.MaSp)]!.HeaderText = "Mã SP";
        dgvProduct.Columns[nameof(Product.TenSp)]!.HeaderText = "Tên sản phẩm";
        dgvProduct.Columns[nameof(Product.DonGia)]!.HeaderText = "Đơn giá";
        dgvProduct.Columns[nameof(Product.DonGia)]!.DefaultCellStyle.Format = "N0";
        dgvProduct.Columns[nameof(Product.SoLuong)]!.HeaderText = "Số lượng";
        dgvProduct.Columns[nameof(Product.DonViTinh)]!.HeaderText = "ĐVT";
    }

    private Product ReadInput() => new()
    {
        MaSp = txtMa.Text.Trim(),
        TenSp = txtTen.Text.Trim(),
        DonGia = numGia.Value,
        SoLuong = (int)numSl.Value,
        DonViTinh = txtDvt.Text.Trim()
    };

    private bool ValidateInput(bool adding)
    {
        var p = ReadInput();
        if (string.IsNullOrWhiteSpace(p.MaSp) || string.IsNullOrWhiteSpace(p.TenSp))
        {
            MessageBox.Show("Vui lòng nhập Mã SP và Tên sản phẩm.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        if (adding && ProductRepository.Exists(p.MaSp))
        {
            MessageBox.Show("Mã sản phẩm đã tồn tại.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(adding: true))
        {
            return;
        }

        ProductRepository.Add(ReadInput());
        RefreshData();
        Notify($"Thêm sản phẩm {txtMa.Text.Trim()} thành công.");
        btnClear_Click(sender, e);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(adding: false))
        {
            return;
        }

        if (!ProductRepository.Update(ReadInput()))
        {
            MessageBox.Show("Không tìm thấy sản phẩm để sửa. Hãy chọn một dòng trên lưới.", "Không tìm thấy",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        RefreshData();
        Notify($"Cập nhật sản phẩm {txtMa.Text.Trim()} thành công.");
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtMa.Clear();
        txtTen.Clear();
        numGia.Value = 0;
        numSl.Value = 0;
        txtDvt.Text = "Cái";
        txtMa.Focus();
    }

    private void mnuDelete_Click(object sender, EventArgs e)
    {
        if (dgvProduct.CurrentRow?.DataBoundItem is not Product p)
        {
            MessageBox.Show("Hãy chọn một dòng để xóa.", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (MessageBox.Show($"Xóa sản phẩm {p.MaSp} - {p.TenSp}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        ProductRepository.Delete(p.MaSp);
        RefreshData();
        Notify($"Đã xóa sản phẩm {p.MaSp}.");
        btnClear_Click(sender, e);
    }

    private void mnuRefresh_Click(object sender, EventArgs e)
    {
        RefreshData();
        Notify("Đã làm mới danh sách sản phẩm.");
    }

    private void mnuDetail_Click(object sender, EventArgs e)
    {
        if (dgvProduct.CurrentRow?.DataBoundItem is not Product p)
        {
            MessageBox.Show("Hãy chọn một dòng để xem chi tiết.", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var dlg = new FormDetail("Chi tiết sản phẩm",
        [
            ("Mã SP", p.MaSp),
            ("Tên SP", p.TenSp),
            ("Đơn giá", p.DonGia.ToString("N0")),
            ("Số lượng", p.SoLuong.ToString()),
            ("ĐVT", p.DonViTinh)
        ]);
        dlg.ShowDialog(this);
        Notify($"Đang xem chi tiết sản phẩm {p.MaSp}.");
    }

    private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dgvProduct.CurrentRow?.DataBoundItem is not Product p)
        {
            return;
        }

        txtMa.Text = p.MaSp;
        txtTen.Text = p.TenSp;
        numGia.Value = p.DonGia;
        numSl.Value = p.SoLuong;
        txtDvt.Text = p.DonViTinh;
    }

    private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => mnuDetail_Click(sender, e);

    private void dgvProduct_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
        {
            return;
        }

        var hit = dgvProduct.HitTest(e.X, e.Y);
        if (hit.RowIndex >= 0)
        {
            dgvProduct.ClearSelection();
            dgvProduct.Rows[hit.RowIndex].Selected = true;
            dgvProduct.CurrentCell = dgvProduct.Rows[hit.RowIndex].Cells[0];
        }
    }

    private void Notify(string message)
    {
        if (MdiParent is IStatusMessenger host)
        {
            host.ShowStatus(message);
        }
    }
}
