namespace bahbashApp.Views;

public partial class ProfileView : ContentPageBase
{
	public ProfileView(ProfileViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
