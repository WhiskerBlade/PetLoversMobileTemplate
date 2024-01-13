using CommunityToolkit.Mvvm.Input;
using PetLovers.Views.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLovers.ViewModels.Auth
{
    public partial class RegisterPageViewModel : BaseViewModel
    {

        [RelayCommand]
        private async void CreateAccountClicked()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
        [RelayCommand]
        private async void LoginClicked()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
