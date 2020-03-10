using System;
using PlacesApp.Controls;
using PlacesApp.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedNavigationPage), typeof(ExtendedNavigationPageRenderer))]
namespace PlacesApp.iOS.Renderers
{
    public class ExtendedNavigationPageRenderer : NavigationRenderer
    {
        public ExtendedNavigationPageRenderer()
        {

        }
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            UINavigationBar.Appearance.ShadowImage = new UIImage();
            UINavigationBar.Appearance.TintColor = UIColor.Clear;
            if(UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
                NavigationBar.StandardAppearance.ShadowColor = UIColor.Clear;

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }

            base.Dispose(disposing);
        }
    }
}
