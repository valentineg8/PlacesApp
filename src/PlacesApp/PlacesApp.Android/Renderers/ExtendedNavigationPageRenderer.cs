using System;
using Android.Content;
using Android.Views;
using PlacesApp.Controls;
using PlacesApp.Droid.Renderers;
using Plugin.SharedTransitions.Platforms.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedNavigationPage), typeof(ExtendedNavigationPageRenderer))]
namespace PlacesApp.Droid.Renderers
{
    public class ExtendedNavigationPageRenderer : SharedTransitionNavigationPageRenderer
    {
        public ExtendedNavigationPageRenderer(Context context) : base(context)
        {

        }

        IPageController PageController => Element as IPageController;
        ExtendedNavigationPage CustomNavigationPage => Element as ExtendedNavigationPage;

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            CustomNavigationPage.IgnoreLayoutChange = true;
            base.OnLayout(changed, l, t, r, b);
            CustomNavigationPage.IgnoreLayoutChange = false;

            int containerHeight = b - t;

            PageController.ContainerArea = new Rectangle(0, 0, Context.FromPixels(r - l), Context.FromPixels(containerHeight));

            for (var i = 0; i < ChildCount; i++)
            {
                Android.Views.View child = GetChildAt(i);

                if (child is Android.Support.V7.Widget.Toolbar)
                {
                    continue;
                }

                child.Layout(0, 0, r, b);
            }
        }
    }
}
