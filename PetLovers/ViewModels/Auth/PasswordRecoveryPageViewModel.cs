using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetLovers.Views.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLovers.ViewModels.Auth
{
    public partial class PasswordRecoveryPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(SecondaryTitle))]
        [NotifyPropertyChangedFor(nameof(ButtonText))]
        bool setNewPasswordMode = false;

        public string SecondaryTitle => SetNewPasswordMode ? "Entrer your new password" : "Enter your email to recover your password";

        public string ButtonText => SetNewPasswordMode ? "Reset my password" : "Send Email";

        [RelayCommand]
        private async void ButtonClicked()
        {
            if(SetNewPasswordMode)
            {
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
            if (!SetNewPasswordMode)
            {
                 SetNewPasswordMode = true;
                return;
            }
        }
    }
}
