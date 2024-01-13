using PetLovers.ViewModels.Auth;

namespace PetLovers.Views.Auth;

public partial class PasswordRecoveryPage : ContentPage
{
	private readonly PasswordRecoveryPageViewModel _viewModel;
	public PasswordRecoveryPage(PasswordRecoveryPageViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}