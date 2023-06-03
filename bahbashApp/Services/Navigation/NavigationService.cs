
using bahbashApp.Services.Authentication;

namespace bahbashApp.Services.Navigation
{
    internal class NavigationService : INavigationService
    {
        private readonly IAuthenticationService authenticationService;

        public NavigationService(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

        public Task InitializeAsync() => !authenticationService.IsAuthenticated ? 
        NavigateToAsync("//login" ) :
            NavigateToAsync("//main/profile");

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            var shellNavigation = new ShellNavigationState(route);

            return routeParameters != null
                ? Shell.Current.GoToAsync(shellNavigation, routeParameters)
                : Shell.Current.GoToAsync(shellNavigation);
        }

        public Task PopAsync() =>
            Shell.Current.GoToAsync("..");
    }
}
