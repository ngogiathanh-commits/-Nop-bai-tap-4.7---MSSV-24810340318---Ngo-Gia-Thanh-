namespace Bai47_MDI.Models;

internal sealed class Student
{
    public string MaSv { get; set; } = string.Empty;
    public string HoTen { get; set; } = string.Empty;
    public DateTime NgaySinh { get; set; } = DateTime.Today.AddYears(-20);
    public string GioiTinh { get; set; } = "Nam";
    public string Lop { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string DienThoai { get; set; } = string.Empty;
}
