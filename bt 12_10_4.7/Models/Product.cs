namespace Bai47_MDI.Models;

internal sealed class Product
{
    public string MaSp { get; set; } = string.Empty;
    public string TenSp { get; set; } = string.Empty;
    public decimal DonGia { get; set; }
    public int SoLuong { get; set; }
    public string DonViTinh { get; set; } = "Cái";
}
