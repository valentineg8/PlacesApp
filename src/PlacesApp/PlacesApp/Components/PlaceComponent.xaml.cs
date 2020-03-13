using System;
using System.Collections.Generic;
using PlacesApp.Models;
using Prism.Commands;
using Xamarin.Forms;

namespace PlacesApp.Components
{
    public partial class PlaceComponent : StackLayout
    {
        public static readonly BindableProperty GoToDetailCommandProperty =
           BindableProperty.Create(nameof(GoToDetailCommand), typeof(DelegateCommand<Place>), typeof(PlaceComponent));


        public DelegateCommand<Place> GoToDetailCommand
        {
            get { return (DelegateCommand<Place>)GetValue(GoToDetailCommandProperty); }
            set { SetValue(GoToDetailCommandProperty, value); }
        }

        public static readonly BindableProperty ListLayoutProperty =
           BindableProperty.Create(nameof(ListLayout), typeof(ListLayoutOptions), typeof(PlaceComponent), null, BindingMode.OneWay, propertyChanged: ListLayoutChange);


        public ListLayoutOptions ListLayout
        {
            get { return (ListLayoutOptions)GetValue(ListLayoutProperty); }
            set { SetValue(ListLayoutProperty, value); }
        }

        static void ListLayoutChange(object bindable, object oldValue, object newValue)
        {
            var elemnt = (PlaceComponent)bindable;
            if ((ListLayoutOptions)newValue == ListLayoutOptions.Big)
            {
                var newBounds = new Rectangle(elemnt.container.Bounds.X, elemnt.container.Bounds.Y, elemnt.container.Bounds.Width, 200);
                elemnt.imgContainer.LayoutTo(newBounds, 100, Easing.Linear);
                var parentAnimation = new Animation
                {
                    { 0, 1, new Animation(v => elemnt.HeightRequest = v, elemnt.HeightRequest, 300, Easing.Linear) }
                };
                parentAnimation.Commit(elemnt, "parentAnimationUp", 60, 100, null, (e, z) => {
                    elemnt.container.LayoutTo(newBounds, 200, Easing.Linear);
                    elemnt.textContainer.LayoutTo(new Rectangle(0, 200, elemnt.container.Bounds.Width, 80), 200, Easing.Linear);

                });
            }
            else
            {
                var parentAnimation = new Animation
                {
                    { 0, 1, new Animation(v => elemnt.HeightRequest = v, elemnt.HeightRequest, 100, Easing.Linear) }
                };
                var newBoundImage = new Rectangle(elemnt.container.Bounds.X, elemnt.container.Bounds.Y, 100, 100);
                elemnt.imgContainer.LayoutTo(newBoundImage, 200, Easing.Linear);
                parentAnimation.Commit(elemnt, "parentAnimationDown", 16, 100, null, (e, z) => {
                    var newBounds = new Rectangle(elemnt.container.Bounds.X, elemnt.container.Bounds.Y, elemnt.container.Bounds.Width, 100);
                    elemnt.container.LayoutTo(newBounds, 100, Easing.Linear);
                    elemnt.textContainer.LayoutTo(new Rectangle(110, 0, elemnt.container.Bounds.Width - 120, 80), 100, Easing.Linear);
                });
            }
        }

        public PlaceComponent()
        {
            InitializeComponent();
            if (ListLayout == ListLayoutOptions.Big)
            {
                HeightRequest = 300;
                AbsoluteLayout.SetLayoutBounds(container, new Rectangle(0, 0, 1, 200));
                AbsoluteLayout.SetLayoutFlags(container, AbsoluteLayoutFlags.WidthProportional);

                AbsoluteLayout.SetLayoutBounds(imgContainer, new Rectangle(0, 0, 1, 200));
                AbsoluteLayout.SetLayoutFlags(imgContainer, AbsoluteLayoutFlags.WidthProportional);


                AbsoluteLayout.SetLayoutBounds(textContainer, new Rectangle(0, 200, 1, 80));
                AbsoluteLayout.SetLayoutFlags(textContainer, AbsoluteLayoutFlags.WidthProportional);
            }
            else
            {
                HeightRequest = 100;
                AbsoluteLayout.SetLayoutBounds(container, new Rectangle(0, 0, 1, 100));
                AbsoluteLayout.SetLayoutFlags(container, AbsoluteLayoutFlags.WidthProportional);

                AbsoluteLayout.SetLayoutBounds(imgContainer, new Rectangle(0, 0, 100, 100));
                AbsoluteLayout.SetLayoutFlags(imgContainer, AbsoluteLayoutFlags.None);

                AbsoluteLayout.SetLayoutBounds(textContainer, new Rectangle(110, 0, .7, 80));
                AbsoluteLayout.SetLayoutFlags(textContainer, AbsoluteLayoutFlags.WidthProportional);
            }
        }
    }
}
