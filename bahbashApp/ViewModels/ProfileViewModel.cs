using bahbashApp.Services.Navigation;
using bahbashApp.ViewModels.Base;

namespace bahbashApp.ViewModels
{
    public class ProfileViewModel : ViewModelBase
    {
        public ProfileViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}

