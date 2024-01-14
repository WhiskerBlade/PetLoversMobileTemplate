using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLovers.ViewModels.Home
{
    public partial class BottomTabsPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        int selectedViewModelIndex;

        public BottomTabsPageViewModel()
        {
            HomePageViewModel = new HomePageViewModel();
            MyProfilePageViewModel = new MyProfilePageViewModel();
        }

        public HomePageViewModel HomePageViewModel { get; }

        public MyProfilePageViewModel MyProfilePageViewModel { get; }
    }
}
