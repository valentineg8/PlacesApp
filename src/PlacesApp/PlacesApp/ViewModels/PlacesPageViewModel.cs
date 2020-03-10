using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;

namespace PlacesApp.ViewModels
{
    public class PlacesPageViewModel : BindableBase, INotifyPropertyChanged
    {
        public ObservableCollection<string> Items { get; set; }
        public string Item { get; set; }
        public DelegateCommand<string> GoToDetailCommand { get; set; }
        public PlacesPageViewModel()
        {
            GoToDetailCommand = new DelegateCommand<string>(GoToDetail);
            Items = new ObservableCollection<string>
            {
                "https://www.fodors.com/wp-content/uploads/2019/12/WinterBeachEscapes__HERO_shutterstock_1271867908.jpg",
                "https://q-cf.bstatic.com/images/hotel/max1024x768/220/220680927.jpg",
                "https://www.fodors.com/wp-content/uploads/2019/12/WinterBeachEscapes__HERO_shutterstock_1271867908.jpg",
                "https://q-cf.bstatic.com/images/hotel/max1024x768/220/220680927.jpg"
            };

        }
        async void GoToDetail(string e)
        {
            await Task.Delay(2000);
        }
    }
}
