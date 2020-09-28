using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Octopus.LibraryManager.ViewModels.LibraryExplorerViewModel;
using ReactiveUI;

namespace Octopus.LibraryManager.Views.LibraryExplorerView
{
    /// <summary>
    /// Interaction logic for LibraryExplorerView.xaml
    /// </summary>
    public partial class LibraryExplorerView : ReactiveUserControl<LibraryExplorerViewModel>
    {
        public LibraryExplorerView()
        {
            InitializeComponent();
        }
    }
}
