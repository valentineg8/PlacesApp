using System;
using System.Collections.Generic;
using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace PlacesApp.Controls
{
    public partial class ExtendedNavigationPage : SharedTransitionNavigationPage
    {
        public bool IgnoreLayout { get; set; } = false;
        public ExtendedNavigationPage(Page page) : base(page)
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            if (!IgnoreLayout)
                base.OnSizeAllocated(width, height);
        }
    }
}
