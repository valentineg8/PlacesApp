using System;
using System.Collections.Generic;
using PlacesApp.Controls;
using Xamarin.Forms;

namespace PlacesApp.Views
{
    public partial class PlaceDetailPage : ContentPage
    {
        public PlaceDetailPage()
        {
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            detailContainer.FadeTo(1, 250, Easing.SinInOut);
            detailContainer.TranslateTo(0, 0, 250, Easing.SinInOut);

            descriptionContainer.FadeTo(1, 500, Easing.SinInOut);
            descriptionContainer.TranslateTo(0, 0, 500, Easing.SinInOut);
        }
    }
}
