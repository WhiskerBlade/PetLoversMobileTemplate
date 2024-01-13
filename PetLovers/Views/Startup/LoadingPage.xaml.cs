using PetLovers.ViewModels.Startup;

namespace PetLovers.Views.Startup;

public partial class LoadingPage : ContentPage
{
	private readonly LoadingPageViewModel _viewModel;
	public LoadingPage(LoadingPageViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}