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
            detailContainer.FadeTo(1, 200, Easing.CubicInOut);
            detailContainer.TranslateTo(0, 0, 200, Easing.CubicInOut);

            descriptionContainer.FadeTo(1, 350, Easing.CubicInOut);
            descriptionContainer.TranslateTo(0, 0, 350, Easing.CubicInOut);
        }
    }
}
