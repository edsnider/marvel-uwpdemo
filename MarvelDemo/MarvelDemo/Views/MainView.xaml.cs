using Windows.UI.Xaml.Navigation;
using MarvelDemo.Core.Models;
using MarvelDemo.Core.Services;
using MarvelDemo.Core.ViewModels;
using MarvelDemo.Services;

namespace MarvelDemo.Views
{
    public sealed partial class MainView
    {
        MainViewModel Vm => DataContext as MainViewModel;

        public MainView()
        {
            InitializeComponent();

            // TODO: IoC
            var hashService = new HashService();
            var dataService = new MarvelDataService(hashService);

            DataContext = new MainViewModel(dataService);
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var character = e.Parameter as Character;
            await Vm.Init(character);
        }
    }
}
