using PetLovers.Views.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLovers.ViewModels.Startup
{
    public partial class LoadingPageViewModel : BaseViewModel
    {
        public LoadingPageViewModel() 
        {
            CheckAuth();
        }

        private async Task CheckAuth()
        {
            Task.Delay(5000).Wait();

            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }

}
