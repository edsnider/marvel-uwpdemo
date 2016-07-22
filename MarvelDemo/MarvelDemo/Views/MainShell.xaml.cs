using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MarvelDemo.Core.Models;
using MarvelDemo.Core.ViewModels;

namespace MarvelDemo.Views
{
    public sealed partial class MainShell
    {
        public MainShell()
        {
            InitializeComponent();

            DataContext = new MainShellViewModel();
            PaneGrid.Width = MainSplitView.IsPaneOpen ? MainSplitView.OpenPaneLength : MainSplitView.CompactPaneLength;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
            PaneGrid.Width = MainSplitView.IsPaneOpen ? MainSplitView.OpenPaneLength : MainSplitView.CompactPaneLength;
        }

        private void NavItemsList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = NavItemsList.SelectedItem as Character;
            ContentFrame.Navigate(typeof(MainView), selectedItem);
        }

        private void InfoButton_OnClickButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(AboutView));
        }
    }
}
