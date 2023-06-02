namespace bahbashApp.Views;

public partial class SignInView : ContentPage
{
	public SignInView()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_SignUP(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignUp");
    }
}