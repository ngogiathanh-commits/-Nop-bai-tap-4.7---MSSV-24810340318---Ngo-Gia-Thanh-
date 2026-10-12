using Bai47_MDI.Models;

namespace Bai47_MDI.Data;

internal static class ProductRepository
{
    private static readonly List<Product> Items =
    [
        new() { MaSp = "SP001", TenSp = "Bàn phím cơ", DonGia = 890000, SoLuong = 15, DonViTinh = "Cái" },
        new() { MaSp = "SP002", TenSp = "Chuột không dây", DonGia = 250000, SoLuong = 40, DonViTinh = "Cái" },
        new() { MaSp = "SP003", TenSp = "Màn hình 24 inch", DonGia = 3200000, SoLuong = 8, DonViTinh = "Cái" }
    ];

    public static List<Product> GetAll() => Items.Select(Clone).ToList();

    public static void Add(Product product) => Items.Add(Clone(product));

    public static bool Update(Product product)
    {
        var index = Items.FindIndex(x => x.MaSp.Equals(product.MaSp, StringComparison.OrdinalIgnoreCase));
        if (index < 0)
        {
            return false;
        }

        Items[index] = Clone(product);
        return true;
    }

    public static bool Delete(string maSp)
    {
        return Items.RemoveAll(x => x.MaSp.Equals(maSp, StringComparison.OrdinalIgnoreCase)) > 0;
    }

    public static bool Exists(string maSp) =>
        Items.Any(x => x.MaSp.Equals(maSp, StringComparison.OrdinalIgnoreCase));

    private static Product Clone(Product p) => new()
    {
        MaSp = p.MaSp,
        TenSp = p.TenSp,
        DonGia = p.DonGia,
        SoLuong = p.SoLuong,
        DonViTinh = p.DonViTinh
    };
}
