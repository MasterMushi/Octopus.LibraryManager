using Octopus.LibraryManager.Models.LibraryExplorerModels;
using ReactiveUI;

namespace Octopus.LibraryManager.ViewModels.LibraryExplorerViewModel
{
    public class LibraryExplorerViewModel : ReactiveObject
    {
        public LibraryExplorerViewModel()
        {
            var category1 = new 
            Library = new ReactiveList<TreeItem> {};

        }

        public ReactiveList<TreeItem> Library { get; }

        private TreeItem _selectedItem;

        public TreeItem SelectedItem
        {
            get => _selectedItem;
            set => this.RaiseAndSetIfChanged(ref _selectedItem, value);
        }
    }
}
