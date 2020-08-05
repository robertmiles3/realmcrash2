using System.Collections.ObjectModel;
using MvvmHelpers.Commands;
using realmcrash.Models;

namespace realmcrash.ViewModels
{
    public class FolderDetailViewModel : BaseViewModel
    {
        public Folder Folder { get; set; }

        public FolderDetailViewModel(Folder folder)
        {
            Title = folder?.Title;
            // Also tried this and get the same exception
            //Folder = DataStore.Find<Folder>(folder.Id);
            Folder = folder;
        }

        private Command removeItemCommand;
        public Command RemoveItemCommand
        {
            get => removeItemCommand ?? (removeItemCommand = new Command<Item>((item) => RemoveItem(item)));
        }

        private void RemoveItem(Item item)
        {
            DataStore.Write(() => Folder.Items.Remove(item));
        }
    }
}
