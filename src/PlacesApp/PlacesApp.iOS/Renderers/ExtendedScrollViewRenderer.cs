using System;
using CoreGraphics;
using PlacesApp.Controls;
using PlacesApp.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedScrollView), typeof(ExtendedScrollViewRenderer))]
namespace PlacesApp.iOS.Renderers
{
    public class ExtendedScrollViewRenderer : ScrollViewRenderer
    {
        public ExtendedScrollViewRenderer()
        {
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
            {
                return;
            }
            this.Scrolled += PreventingTopBounce;

            if (UIDevice.CurrentDevice.CheckSystemVersion(11, 0))
            {
                var element = (ExtendedScrollView)Element;
                if (!element.HasTopPadding)
                    this.ContentInsetAdjustmentBehavior = UIScrollViewContentInsetAdjustmentBehavior.Never;
            }
        }

        private void PreventingTopBounce(object sender, EventArgs e)
        {
            if (this.ContentOffset.Y < 0)
            {
                this.SetContentOffset(new CGPoint(this.ContentOffset.X, 0), false);
            }
        }

    }
}
