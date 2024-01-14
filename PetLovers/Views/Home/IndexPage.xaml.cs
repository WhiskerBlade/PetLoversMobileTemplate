using PetLovers.ViewModels.Home;

namespace PetLovers.Views.Home;

public partial class IndexPage : ContentPage
{
	private readonly BottomTabsPageViewModel _viewModel;
	public IndexPage(BottomTabsPageViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}