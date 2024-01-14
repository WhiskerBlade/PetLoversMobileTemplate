using CommunityToolkit.Mvvm.ComponentModel;
using PetLovers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLovers.ViewModels.Home
{
    public partial class MyProfilePageViewModel : BaseViewModel
    {
        [ObservableProperty]
        LoggedInUser user;
        public MyProfilePageViewModel() 
        {
            User = LoggedInUser.Current;
        }
    }
}
