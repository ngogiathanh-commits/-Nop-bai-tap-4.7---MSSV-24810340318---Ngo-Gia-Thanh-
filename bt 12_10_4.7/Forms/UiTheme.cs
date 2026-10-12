namespace Bai47_MDI.Forms;

internal static class UiTheme
{
    public static readonly Color Primary = Color.FromArgb(25, 55, 95);
    public static readonly Color Accent = Color.FromArgb(0, 120, 215);
    public static readonly Color Surface = Color.FromArgb(245, 247, 250);

    public static Font TitleFont => new("Segoe UI", 14F, FontStyle.Bold);
    public static Font BodyFont => new("Segoe UI", 9.5F);

    public static Bitmap MakeIcon(Color color, string mark)
    {
        var bmp = new Bitmap(20, 20);
        using var g = Graphics.FromImage(bmp);
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.Clear(Color.Transparent);
        using (var brush = new SolidBrush(color))
        {
            g.FillEllipse(brush, 1, 1, 18, 18);
        }

        using var font = new Font("Segoe UI", 8F, FontStyle.Bold);
        var size = g.MeasureString(mark, font);
        g.DrawString(mark, font, Brushes.White, (20 - size.Width) / 2, (20 - size.Height) / 2);
        return bmp;
    }
}
