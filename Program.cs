using PabDealership.Controllers;
using PabDealership.Views;
namespace PabDealership
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            PabDealershipController controller = new PabDealershipController();
            Application.Run();
            Application.Run(new PabDealershipForm(controller));
        }
    }
}