using bahbashApp.Services.Settings;

namespace bahbashApp.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ISettingsService settingsService;

        public AuthenticationService(ISettingsService settingsService)
        {
            this.settingsService = settingsService;
        }

        public bool IsAuthenticated => !string.IsNullOrEmpty(settingsService.AuthAccessToken);
    }
}

