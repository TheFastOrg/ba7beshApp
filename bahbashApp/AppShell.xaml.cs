using System.Globalization;
using bahbashApp.Services.Navigation;

namespace bahbashApp;

public partial class AppShell : Shell
{
    private readonly INavigationService _navigationService;

    public AppShell(INavigationService navigationService)
    {
        _navigationService = navigationService;

        InitializeComponent();
        FlowDirection = CultureInfo.CurrentCulture.Name.StartsWith("ar")
            ? FlowDirection.RightToLeft
            : FlowDirection.LeftToRight;
    }

    protected override async void OnHandlerChanged()
    {
        base.OnHandlerChanged();

        if (Handler is not null) await _navigationService.InitializeAsync();
    }
}