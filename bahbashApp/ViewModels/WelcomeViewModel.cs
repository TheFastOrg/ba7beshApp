using bahbashApp.Services.Navigation;
using bahbashApp.ViewModels.Base;
using System.Windows.Input;

namespace bahbashApp.ViewModels;

public partial class WelcomeViewModel : ViewModelBase
{
    // authentication url should be editing according to the backend
    const string authenticationUrl = "https://backend/socialauth/";
    public WelcomeViewModel(INavigationService navigationService) : base(navigationService)
    {
        // Schema should be edited according to backend
        GoogleCommand = new Command(async () => await OnAuthenticate("Google"));
        FacebookCommand = new Command(async () => await OnAuthenticate("Facebook"));
    }

    public ICommand GoogleCommand { get; }

    public ICommand FacebookCommand { get; }

    string accessToken = string.Empty;

    public string AuthToken
    {
        get => accessToken;
        set => SetProperty(ref accessToken, value);
    }

    async Task OnAuthenticate(string scheme)
    {
        try
        {
            Console.WriteLine("Auth with "+ scheme);
            WebAuthenticatorResult r = null;
           
            var authUrl = new Uri(authenticationUrl + scheme);
            var callbackUrl = new Uri("bahbashapp://");

            r = await WebAuthenticator.AuthenticateAsync(authUrl, callbackUrl);

            AuthToken = string.Empty;
            // the following retrived values should be changed depending on the response body from backend.
            if (r.Properties.TryGetValue("name", out var name) && !string.IsNullOrEmpty(name))
                AuthToken += $"Name: {name}{Environment.NewLine}";
            if (r.Properties.TryGetValue("email", out var email) && !string.IsNullOrEmpty(email))
                AuthToken += $"Email: {email}{Environment.NewLine}";
            AuthToken += r?.AccessToken ?? r?.IdToken;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Login canceled.");

            AuthToken = string.Empty;
            //await DisplayAlertAsync("Login canceled.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed: {ex.Message}");

            AuthToken = string.Empty;
            //await DisplayAlertAsync($"Failed: {ex.Message}");
        }
    }

    [RelayCommand]
    private async Task Skip()
    {
        await NavigationService.NavigateToAsync("//profile");
    }
}