using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PrescriptionManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var authManager = AuthenticationManager.Instance;

            var loggedIn = await authManager.RefreshTokenAsync();

            if (loggedIn)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
