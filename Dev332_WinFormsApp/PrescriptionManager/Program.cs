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
                if (await authManager.IsUserInGroup(Settings.PrescriptionManagerUsersGroupId))
                {
                    Application.Run(new MainForm());
                }
                else
                {
                    MessageBox.Show("The current user is not a member of the PrescriptionManagerUsers group!");
                }
            }
        }
    }
}
