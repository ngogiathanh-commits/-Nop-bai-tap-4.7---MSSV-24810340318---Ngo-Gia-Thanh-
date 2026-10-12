namespace Bai47_MDI.Services;

internal static class AppSession
{
    public static string CurrentUser { get; set; } = "Khách";
    public static bool RequestRelogin { get; set; }
}
