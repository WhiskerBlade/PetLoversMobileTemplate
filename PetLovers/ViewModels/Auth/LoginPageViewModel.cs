using CommunityToolkit.Mvvm.Input;
using PetLovers.Views.Auth;
using PetLovers.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLovers.ViewModels.Auth
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [RelayCommand]
        private async void LoginClicked()
        {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }

        [RelayCommand]
        private async void CreateAccountClicked()
        {
            await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
        }

        [RelayCommand]
        private async void ForgotPasswordClicked()
        {
            await Shell.Current.GoToAsync($"//{nameof(PasswordRecoveryPage)}");
        }
    }
}
