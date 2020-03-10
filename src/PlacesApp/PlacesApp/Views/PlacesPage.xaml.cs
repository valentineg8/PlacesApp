using System;
using System.Collections.Generic;
using PlacesApp.Controls;
using Xamarin.Forms;

namespace PlacesApp.Views
{
    public partial class PlacesPage : ContentPage
    {
        public PlacesPage()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            barSelector.TranslateTo(((Label)sender).X + 15, 0, 300, Easing.SinOut);
        }
    }
}
