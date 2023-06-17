using bahbashApp.Services.Navigation;
using bahbashApp.ViewModels.Base;

namespace bahbashApp.ViewModels;

public partial class WelcomeViewModel : ViewModelBase
{
    public WelcomeViewModel(INavigationService navigationService) : base(navigationService)
    {
    }

    [RelayCommand]
    private async Task Skip()
    {
        await NavigationService.NavigateToAsync("//profile");
    }
}