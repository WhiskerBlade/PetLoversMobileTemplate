using PetLovers.ViewModels.Auth;

namespace PetLovers.Views.Auth;

public partial class RegisterPage : ContentPage
{
	private readonly RegisterPageViewModel _viewModel;
	public RegisterPage(RegisterPageViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}