using PetLovers.ViewModels.Auth;

namespace PetLovers.Views.Auth;

public partial class LoginPage : ContentPage
{
	private readonly LoginPageViewModel _viewModel;
	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}