using Octopus.LibraryManager.ViewModels;
using ReactiveUI;

namespace Octopus.LibraryManager.Views
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindowView()
        {
            InitializeComponent();
        }
    }
}
