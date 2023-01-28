namespace bahbashApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.SignInPage), typeof(Views.SignInPage));
    }
}
