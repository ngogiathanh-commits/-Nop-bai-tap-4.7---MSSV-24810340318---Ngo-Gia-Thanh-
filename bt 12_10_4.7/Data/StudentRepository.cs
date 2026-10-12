using Bai47_MDI.Models;

namespace Bai47_MDI.Data;

internal static class StudentRepository
{
    private static readonly List<Student> Items =
    [
        new() { MaSv = "SV001", HoTen = "Nguyễn Văn An", NgaySinh = new DateTime(2004, 5, 12), GioiTinh = "Nam", Lop = "CNTT01", Email = "an@gmail.com", DienThoai = "0901111111" },
        new() { MaSv = "SV002", HoTen = "Trần Thị Bình", NgaySinh = new DateTime(2005, 1, 8), GioiTinh = "Nữ", Lop = "CNTT01", Email = "binh@gmail.com", DienThoai = "0902222222" },
        new() { MaSv = "SV003", HoTen = "Lê Minh Châu", NgaySinh = new DateTime(2004, 11, 20), GioiTinh = "Nữ", Lop = "CNTT02", Email = "chau@gmail.com", DienThoai = "0903333333" }
    ];

    public static List<Student> GetAll() => Items.Select(Clone).ToList();

    public static void Add(Student student) => Items.Add(Clone(student));

    public static bool Update(Student student)
    {
        var index = Items.FindIndex(x => x.MaSv.Equals(student.MaSv, StringComparison.OrdinalIgnoreCase));
        if (index < 0)
        {
            return false;
        }

        Items[index] = Clone(student);
        return true;
    }

    public static bool Delete(string maSv)
    {
        return Items.RemoveAll(x => x.MaSv.Equals(maSv, StringComparison.OrdinalIgnoreCase)) > 0;
    }

    public static bool Exists(string maSv) =>
        Items.Any(x => x.MaSv.Equals(maSv, StringComparison.OrdinalIgnoreCase));

    private static Student Clone(Student s) => new()
    {
        MaSv = s.MaSv,
        HoTen = s.HoTen,
        NgaySinh = s.NgaySinh,
        GioiTinh = s.GioiTinh,
        Lop = s.Lop,
        Email = s.Email,
        DienThoai = s.DienThoai
    };
}
