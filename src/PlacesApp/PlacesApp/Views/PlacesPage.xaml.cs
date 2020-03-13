using System;
using System.Collections.Generic;
using PlacesApp.Controls;
using PlacesApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlacesApp.Views
{
    public partial class PlacesPage : ContentPage
    {
        public PlacesPage()
        {
            Xamarin.Forms.NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var safeInsets = On<iOS>().SafeAreaInsets();
            safeInsets.Bottom = 0;
            Padding = safeInsets;
        }

    }
}
