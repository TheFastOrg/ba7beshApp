using bahbashApp.Services.Navigation;
using bahbashApp.ViewModels.Base;

namespace bahbashApp.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    public LoginViewModel(INavigationService navigationService) : base(navigationService)
    {
    }

    [RelayCommand]
    private async Task SignIn()
    {
        await NavigationService.NavigateToAsync("//profile");
    }

    [RelayCommand]
    private async Task SignUp()
    {
        await NavigationService.NavigateToAsync("//profile");
    }
}