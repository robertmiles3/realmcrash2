using Xamarin.Forms;
using realmcrash.Models;
using realmcrash.ViewModels;

namespace realmcrash.Views
{
    public partial class HomePage : ContentPage
    {
        HomeViewModel viewModel;

        public HomePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new HomeViewModel();
        }

        async void FoldersListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (!(e.SelectedItem is Folder folder))
                return;

            await Navigation.PushAsync(new FolderDetailPage(new FolderDetailViewModel(folder)));

            // Manually deselect item.
            FoldersListView.SelectedItem = null;
        }
    }
}