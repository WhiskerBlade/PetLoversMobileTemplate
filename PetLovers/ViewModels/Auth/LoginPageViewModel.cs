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
            App.LoggedInUser = new Models.LoggedInUser {
                FirstName = "Hristo",
                LastName = "Petrov",
                City = "Birkirkara",
                Country = "Malta",
                Avatar = ImageSource.FromUri(new Uri("https://scontent.fmla1-2.fna.fbcdn.net/v/t39.30808-6/405755433_882949696670529_3941208469852205818_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=9c7eae&_nc_ohc=SZAuwSoev9EAX_-zSgW&_nc_ht=scontent.fmla1-2.fna&oh=00_AfAotExoFmcpnRnipP48zM_ieAK0XerDT-U2OemSMz54iA&oe=65A89F12"))
            };
            await Shell.Current.GoToAsync($"//{nameof(IndexPage)}");
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
