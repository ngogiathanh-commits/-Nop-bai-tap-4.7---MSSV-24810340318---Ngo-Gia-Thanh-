using Bai47_MDI.Data;
using Bai47_MDI.Models;
using Bai47_MDI.Services;

namespace Bai47_MDI.Forms;

public partial class FormStudent : Form, IRefreshableChild
{
    private readonly BindingSource _binding = new();

    public FormStudent()
    {
        InitializeComponent();
        dgvStudent.DataSource = _binding;
        Load += (_, _) => RefreshData();
    }

    public void RefreshData()
    {
        _binding.DataSource = StudentRepository.GetAll();
        if (dgvStudent.Columns.Count == 0)
        {
            return;
        }

        dgvStudent.Columns[nameof(Student.MaSv)]!.HeaderText = "Mã SV";
        dgvStudent.Columns[nameof(Student.HoTen)]!.HeaderText = "Họ tên";
        dgvStudent.Columns[nameof(Student.NgaySinh)]!.HeaderText = "Ngày sinh";
        dgvStudent.Columns[nameof(Student.GioiTinh)]!.HeaderText = "Giới tính";
        dgvStudent.Columns[nameof(Student.Lop)]!.HeaderText = "Lớp";
        dgvStudent.Columns[nameof(Student.Email)]!.HeaderText = "Email";
        dgvStudent.Columns[nameof(Student.DienThoai)]!.HeaderText = "Điện thoại";
    }

    private Student ReadInput() => new()
    {
        MaSv = txtMa.Text.Trim(),
        HoTen = txtTen.Text.Trim(),
        NgaySinh = dtpNgaySinh.Value.Date,
        GioiTinh = cboGt.Text,
        Lop = txtLop.Text.Trim(),
        Email = txtEmail.Text.Trim(),
        DienThoai = txtSdt.Text.Trim()
    };

    private bool ValidateInput(bool adding)
    {
        var s = ReadInput();
        if (string.IsNullOrWhiteSpace(s.MaSv) || string.IsNullOrWhiteSpace(s.HoTen))
        {
            MessageBox.Show("Vui lòng nhập Mã SV và Họ tên.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        if (adding && StudentRepository.Exists(s.MaSv))
        {
            MessageBox.Show("Mã sinh viên đã tồn tại.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        StudentRepository.Add(ReadInput());
        RefreshData();
        Notify($"Thêm sinh viên {txtMa.Text.Trim()} thành công.");
        btnClear_Click(sender, e);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(adding: false))
        {
            return;
        }

        if (!StudentRepository.Update(ReadInput()))
        {
            MessageBox.Show("Không tìm thấy sinh viên để sửa. Hãy chọn một dòng trên lưới.", "Không tìm thấy",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        RefreshData();
        Notify($"Cập nhật sinh viên {txtMa.Text.Trim()} thành công.");
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtMa.Clear();
        txtTen.Clear();
        txtLop.Clear();
        txtEmail.Clear();
        txtSdt.Clear();
        cboGt.SelectedIndex = 0;
        dtpNgaySinh.Value = DateTime.Today.AddYears(-20);
        txtMa.Focus();
    }

    private void mnuDelete_Click(object sender, EventArgs e)
    {
        if (dgvStudent.CurrentRow?.DataBoundItem is not Student s)
        {
            MessageBox.Show("Hãy chọn một dòng để xóa.", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (MessageBox.Show($"Xóa sinh viên {s.MaSv} - {s.HoTen}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        StudentRepository.Delete(s.MaSv);
        RefreshData();
        Notify($"Đã xóa sinh viên {s.MaSv}.");
        btnClear_Click(sender, e);
    }

    private void mnuRefresh_Click(object sender, EventArgs e)
    {
        RefreshData();
        Notify("Đã làm mới danh sách sinh viên.");
    }

    private void mnuDetail_Click(object sender, EventArgs e)
    {
        if (dgvStudent.CurrentRow?.DataBoundItem is not Student s)
        {
            MessageBox.Show("Hãy chọn một dòng để xem chi tiết.", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var dlg = new FormDetail("Chi tiết sinh viên",
        [
            ("Mã SV", s.MaSv),
            ("Họ tên", s.HoTen),
            ("Ngày sinh", s.NgaySinh.ToString("dd/MM/yyyy")),
            ("Giới tính", s.GioiTinh),
            ("Lớp", s.Lop),
            ("Email", s.Email),
            ("Điện thoại", s.DienThoai)
        ]);
        dlg.ShowDialog(this);
        Notify($"Đang xem chi tiết sinh viên {s.MaSv}.");
    }

    private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dgvStudent.CurrentRow?.DataBoundItem is not Student s)
        {
            return;
        }

        txtMa.Text = s.MaSv;
        txtTen.Text = s.HoTen;
        dtpNgaySinh.Value = s.NgaySinh;
        cboGt.SelectedItem = s.GioiTinh;
        txtLop.Text = s.Lop;
        txtEmail.Text = s.Email;
        txtSdt.Text = s.DienThoai;
    }

    private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => mnuDetail_Click(sender, e);

    private void dgvStudent_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
        {
            return;
        }

        var hit = dgvStudent.HitTest(e.X, e.Y);
        if (hit.RowIndex >= 0)
        {
            dgvStudent.ClearSelection();
            dgvStudent.Rows[hit.RowIndex].Selected = true;
            dgvStudent.CurrentCell = dgvStudent.Rows[hit.RowIndex].Cells[0];
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
