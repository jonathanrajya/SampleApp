using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            //Resources["Accent"] = Application.Current.RequestedTheme == OSAppTheme.Dark ? Resources["Yellow"] : Color.FromHex("#96d1ff");
        }
    }
}