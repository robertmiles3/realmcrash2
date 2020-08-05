using System.Collections.Generic;
using System.Linq;
using realmcrash.Models;

namespace realmcrash.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Folders = DataStore.Folders.OrderBy(f => f.Title);
        }

        public IEnumerable<Folder> Folders { get; }
    }
}