using PetLovers.ViewModels.Home;

namespace PetLovers.Views.Home;

public partial class HomePage : ContentPage
{
	private readonly HomePageViewModel _viewModel;
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}