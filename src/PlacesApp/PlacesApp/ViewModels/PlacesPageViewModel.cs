using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using PlacesApp.Models;
using PlacesApp.Utils;
using PlacesApp.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms.Internals;

namespace PlacesApp.ViewModels
{
    public class PlacesPageViewModel : ViewModelBase
    {
        public ObservableCollection<Place> Items { get; set; }
        public ObservableCollection<Tab> TabItems { get; set; }
        public Tab Item { get; set; }
        public string SelectedItemId { get; set; }
        public ListLayoutOptions ListLayout { get; set; }
        public string Section { get; set; }
        public DelegateCommand<Place> GoToDetailCommand { get; set; }
        public DelegateCommand<object> ChangeLayoutCommand { get; set; }
        public PlacesPageViewModel(INavigationService  navigationPage) : base(navigationPage)
        {
            GoToDetailCommand = new DelegateCommand<Place>(GoToDetail);
            Items = new ObservableCollection<Place>();
            Item = new Tab();
            ListLayout = ListLayoutOptions.Big;

            ChangeLayoutCommand = new DelegateCommand<object>(ChangeLayout);
        }
        void ChangeLayout(object listLayout)
        {
            ListLayout = (ListLayoutOptions)listLayout;
        }
        async void GoToDetail(Place place)
        {
            SelectedItemId = place.IdAnimation;
            var navParam = new NavigationParameters { { nameof(place), place } };
            await NavigationService.NavigateAsync($"{nameof(PlaceDetailPage)}", navParam);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() != NavigationMode.Back)
            {
                LoadData();
            }
            else
            {
                SelectedItemId = null;
            }
        }
        void LoadData ()
        {
            var all = new List<Place>();
            var trending = new List<Place>();
            var featured = new List<Place>();
            var popular = new List<Place>();
            for (int i = 0; i < Data.places.Count; i++)
            {
                var element = Data.places[i];
                all.Add(new Place
                {
                    Id = element.Id,
                    Description = element.Description,
                    Title = element.Title,
                    SubTitle = element.SubTitle,
                    Images = element.Images,
                    Image = element.Image,
                    IdAnimation = $"All{Guid.NewGuid()}"
                });
                if (element.IsTrending)
                    trending.Add(new Place {
                        Id = element.Id,
                        Description = element.Description,
                        Title = element.Title,
                        SubTitle = element.SubTitle,
                        Images = element.Images,
                        Image = element.Image,
                        IdAnimation = $"Trending{Guid.NewGuid()}"
                    }); 

                if (element.IsFeatured)
                    featured.Add(new Place
                    {
                        Id = element.Id,
                        Description = element.Description,
                        Title = element.Title,
                        SubTitle = element.SubTitle,
                        Images = element.Images,
                        Image = element.Image,
                        IdAnimation = $"Featured${Guid.NewGuid()}"
                    });

                if (element.IsPopular)
                    popular.Add(new Place
                    {
                        Id = element.Id,
                        Description = element.Description,
                        Title = element.Title,
                        SubTitle = element.SubTitle,
                        Images = element.Images,
                        Image = element.Image,
                        IdAnimation = $"Popular{Guid.NewGuid()}"
                    });
            }

            TabItems = new ObservableCollection<Tab>
            {
                new Tab
                {
                    Title="All",
                    Selected = true,
                    Id = "A",
                    Items = all
                },
                 new Tab
                {
                    Title="Featured",
                    Id = "F",
                    Items = featured

                },
                new Tab
                {
                    Title="Popular",
                    Id = "P",
                    Items = popular
                },
                new Tab
                {
                    Title="Trending",
                    Id = "T",
                    Items = trending
                }
            };
        }
        
    }
}
