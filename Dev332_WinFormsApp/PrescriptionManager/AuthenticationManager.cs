using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Windows.Forms;

namespace PrescriptionManager
{
    public class AuthenticationManager
    {
        private static readonly Lazy<AuthenticationManager> Lazy =
            new Lazy<AuthenticationManager>(() => new AuthenticationManager());

        public static AuthenticationManager Instance => Lazy.Value;

        private readonly AuthenticationContext _authContext;

        private AuthenticationManager()
        {
            _authContext = new AuthenticationContext(Settings.Authority);
        }

        public enum LoginMode
        {
            Silent,
            Interactive
        }

        public async Task<bool> RefreshTokenAsync()
        {
            var loggedIn = await LoginAsync(LoginMode.Silent);
            if (!loggedIn)
            {
                loggedIn = await LoginAsync(LoginMode.Interactive);
            }

            return loggedIn;
        }

        public AuthenticationResult AuthResult { get; private set; }

        public async Task<bool> LoginAsync(LoginMode loginMode)
        {
            try
            {
                AuthResult = await _authContext.AcquireTokenAsync(
                    Settings.GraphResourceId,
                    Settings.ClientId,
                    Settings.RedirectUri,
                    new PlatformParameters(loginMode == LoginMode.Silent ?
                                                        PromptBehavior.Always :
                                                        PromptBehavior.SelectAccount));

                return true;
            }
            catch (AdalException ex)
            {
                if (ex.ErrorCode != "user_interaction_required")
                {
                    // An unexpected error occurred.
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
        }
    }
}
