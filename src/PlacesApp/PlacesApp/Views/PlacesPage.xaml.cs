using System;
using System.Collections.Generic;
using PlacesApp.Controls;
using PlacesApp.Models;
using Xamarin.Forms;

namespace PlacesApp.Views
{
    public partial class PlacesPage : ContentPage
    {
        public PlacesPage()
        {
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
        }

    }
}
