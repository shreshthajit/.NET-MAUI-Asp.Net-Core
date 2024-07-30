using IceCreamMAUI.Pages;

namespace IceCreamMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoute();

        }

        private readonly static Type[] _routablePageTypes =
            [
            typeof(SigninPage),
            typeof(SignupPage),
            typeof(MyOrdersPage),
            typeof(OrderDetailsPage),
            typeof(DetailsPage),
            ];

        private static void RegisterRoute()
        {
            foreach(var pageType in _routablePageTypes)
            {
                Routing.RegisterRoute(pageType.Name, pageType);//in the bracket nameof(SigninPage) is route name
            }
        }

        private async void FlyoutFooter_Tapped(object sender, TappedEventArgs e)
        {
            await Launcher.OpenAsync("https://github.com/shreshthajit");
        }

        private async void SignoutMenuItem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.DisplayAlert("Alert", "Signout menu item clicked", "ok");
        }
    }
}
