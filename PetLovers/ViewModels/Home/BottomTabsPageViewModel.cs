using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetLovers.Helpers;
using PetLovers.Views;
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

        [RelayCommand]
        public async void OnCameraButtonClicked()
        {
            bool IsCameraGranted = await PermissionsHelper.RequestPermission<Permissions.Camera>();

            if (IsCameraGranted)
            {
                await Shell.Current.Navigation.PushModalAsync(new CameraPage());
            }
        }
    }
}
