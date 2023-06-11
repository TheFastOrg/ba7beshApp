namespace bahbashApp.Views;

public partial class SignInView : ContentPageBase
{
	public SignInView(LoginViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}