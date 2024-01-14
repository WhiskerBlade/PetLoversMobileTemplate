using PetLovers.Models;

namespace PetLovers
{
    public partial class App : Application
    {
        public static LoggedInUser LoggedInUser;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
