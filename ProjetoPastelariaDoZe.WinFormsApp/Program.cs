using System.Configuration;
using System.Globalization;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string? aux = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") : ""; // ? > Pode ser null |
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(aux!); // var! > Pode ser null
            Thread.CurrentThread.CurrentCulture = new CultureInfo(aux!);

            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());
        }
    }
}