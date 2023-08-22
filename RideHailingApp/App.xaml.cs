using System;
using Xamarin.Forms;
using RideHailingApp.Views;
using Xamarin.Forms.Xaml;

namespace RideHailingApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzUwNTU1QDMyMzAyZTMzMmUzMG45OTVLWkFjSUIwbzRURnlTN3ZEWlFVeDBPQkNZUk0zdTJQaXVqa2k5MTg9");

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
