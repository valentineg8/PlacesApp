using System;
using PlacesApp.Models;
using Prism.AppModel;
using Prism.Mvvm;

namespace PlacesApp.ViewModels
{
    public class PlaceDetailPageViewModel : BindableBase, IAutoInitialize
    {
        public Place Place { get; set; }
        public PlaceDetailPageViewModel()
        {
        }
    }
}
