using System.Collections.ObjectModel;
using MarvelDemo.Core.Models;

namespace MarvelDemo.Core.ViewModels
{
    public class MainShellViewModel : BaseViewModel
    {
        ObservableCollection<Character> _navItems;
        public ObservableCollection<Character> NavItems
        {
            get { return _navItems; }
            set
            {
                _navItems = value;
                OnPropertyChanged();
            }
        }

        public MainShellViewModel()
        {
            NavItems = new ObservableCollection<Character>();

            NavItems.Add(new Character {Id = 1009368, Name = "Iron Man", IconPath = "../Assets/NavIcons/ironman_52.png", SeriesId = 2029});
            NavItems.Add(new Character { Id = 1009220, Name = "Captain America", IconPath = "../Assets/NavIcons/captainamerica_52.png", SeriesId = 1996 });
            NavItems.Add(new Character { Id = 1009664, Name = "Thor", IconPath = "../Assets/NavIcons/thor_52.png", SeriesId = 2083 });
        }
    }
}
