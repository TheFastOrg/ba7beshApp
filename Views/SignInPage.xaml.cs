namespace bahbashApp.Views;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_SignUP(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignUp");
    }
}