using PlacesApp.Controls;
using PlacesApp.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;

namespace PlacesApp
{
    [AutoRegisterForNavigation]
    public partial class App
    {
        public static Theme AppTheme { get; set; }
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"{nameof(ExtendedNavigationPage)}/{nameof(PlacesPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ExtendedNavigationPage>();
        }
    }
    public enum Theme { Light, Dark }
}
