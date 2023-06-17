namespace bahbashApp.Views;

public partial class WelcomeView : ContentPageBase
{
	public WelcomeView(WelcomeViewModel welcomeViewModel)
	{
		InitializeComponent();
        BindingContext = welcomeViewModel;
    }
}