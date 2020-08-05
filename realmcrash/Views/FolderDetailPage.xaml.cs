using System;
using Xamarin.Forms;
using realmcrash.ViewModels;

namespace realmcrash.Views
{
    public partial class FolderDetailPage : ContentPage
    {
        FolderDetailViewModel viewModel;

        public FolderDetailPage(FolderDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}
