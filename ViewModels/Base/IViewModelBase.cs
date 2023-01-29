

using bahbashApp.Services.Navigation;

namespace bahbashApp.ViewModels.Base
{
    internal interface IViewModelBase : IQueryAttributable
    {
        public INavigationService NavigationService { get; }
    }
}
