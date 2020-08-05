using MvvmHelpers.Commands;
using realmcrash.Models;
using realmcrash.Services;

namespace realmcrash.ViewModels
{
    public class BaseViewModel : MvvmHelpers.BaseViewModel
    {
        public readonly DataStore DataStore;

        public BaseViewModel()
        {
            DataStore = new DataStore();
        }

        private Command deleteFolderCommand;
        public Command DeleteFolderCommand
        {
            get => deleteFolderCommand ?? (deleteFolderCommand = new Command<Folder>((folder) => DeleteFolder(folder)));
        }

        private void DeleteFolder(Folder folder)
        {
            DataStore.Remove(folder);
        }
    }
}
