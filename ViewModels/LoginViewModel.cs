

using bahbashApp.Services.Navigation;
using bahbashApp.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace bahbashApp.ViewModels
{
    internal class LoginViewModel : ViewModelBase
    {
        public ICommand SignInCommand { get; }
        public LoginViewModel(INavigationService navigationService) : base( navigationService)
        {
           SignInCommand = new AsyncRelayCommand(SignInAsync);
        }
        private async Task SignInAsync()
        {
            await Task.Delay(10);
        }
    }
}
