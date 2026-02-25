using System.Data.SQLite;
using System.Security.Policy;

namespace Digital_Shop_Software
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}