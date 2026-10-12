using Bai47_MDI.Forms;
using Bai47_MDI.Services;

namespace Bai47_MDI;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        while (true)
        {
            using var login = new FormLogin();
            if (login.ShowDialog() != DialogResult.OK)
            {
                break;
            }

            AppSession.RequestRelogin = false;
            Application.Run(new FormMain());

            if (!AppSession.RequestRelogin)
            {
                break;
            }
        }
    }
}
