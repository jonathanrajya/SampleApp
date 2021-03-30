using SampleApp.Services;
using SampleApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp
{
    public partial class App : Application
    {

        public App()
        {
            Device.SetFlags(new string[] { "AppTheme_Experimental" });
            InitializeComponent();
            Resources["Primary"] = Current.RequestedTheme == OSAppTheme.Dark ? Resources["ThemeYellow"] : Resources["ThemeBlue"];
            Resources["Accent"] = Current.RequestedTheme == OSAppTheme.Dark ? Resources["ThemeYellow"] : Color.FromHex("#96d1ff");
            Current.RequestedThemeChanged += (s, a) =>
            {
                // Respond to the theme change
                Resources["Primary"] = a.RequestedTheme == OSAppTheme.Dark ? Resources["ThemeYellow"] : Resources["ThemeBlue"];
                Resources["Accent"] = a.RequestedTheme == OSAppTheme.Dark ? Resources["ThemeYellow"] : Color.FromHex("#96d1ff");
            };

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
