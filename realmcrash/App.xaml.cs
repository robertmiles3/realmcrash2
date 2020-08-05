using realmcrash.Services;
using realmcrash.Views;
using Xamarin.Forms;

namespace realmcrash
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var dataStore = new DataStore();
            dataStore.Reset();
            dataStore.Seed();
            MainPage = new MainPage();
        }
    }
}
