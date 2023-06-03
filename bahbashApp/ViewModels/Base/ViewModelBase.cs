
using bahbashApp.Services.Navigation;

namespace bahbashApp.ViewModels.Base
{
    public class ViewModelBase : ObservableObject
    {
        public INavigationService NavigationService { get; private set; }
        public ViewModelBase( INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            throw new NotImplementedException();
        }
    }
}
