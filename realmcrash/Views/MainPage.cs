using Xamarin.Forms;

namespace realmcrash.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            var HomeNavigationPage = new NavigationPage(new HomePage())
            {
                Title = "Home",
            };

            Children.Add(HomeNavigationPage);
        }
    }
}