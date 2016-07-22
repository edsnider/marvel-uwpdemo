using System;
using Windows.UI.Xaml;

namespace MarvelDemo.Views
{
    public sealed partial class AboutView
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private async void MarvelLinkButton_OnClick(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://developer.marvel.com"));
        }

        private async void Icons8LinkButton_OnClick(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.icons8.com"));
        }
    }
}
