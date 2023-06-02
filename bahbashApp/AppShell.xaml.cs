namespace bahbashApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.SignInView), typeof(Views.SignInView));
    }
}
