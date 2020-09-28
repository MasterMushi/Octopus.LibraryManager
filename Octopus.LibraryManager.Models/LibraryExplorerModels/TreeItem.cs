using Octopus.LibraryManager.Models.Interfaces;

namespace Octopus.LibraryManager.Models.LibraryExplorerModels
{
    public abstract class TreeItem : ReactiveObject
    {
        private ITreeFolder _parent;

        public ITreeFolder Parent
        {
            get => _parent;
            set => this.RaiseAndSetIfChanged(ref _parent, value);
        }

        private ITreeItem _children;

        public ITreeItem Children
        {
            get => _children;
            set => this.RaiseAndSetIfChanged(ref _children, value);
        }

        private string _title;

        public string Title
        {
            get => _title;
            set => this.RaiseAndSetIfChanged(ref _title, value);
        }

        private bool _isExpanded;

        public bool IsExpanded
        {
            get => _isExpanded;
            set => this.RaiseAndSetIfChanged(ref _isExpanded, value);
        }

        private bool _isSelected;

        public bool IsSelected
        {
            get => _isSelected;
            set => this.RaiseAndSetIfChanged(ref _isSelected, value);
        }

    }
}
