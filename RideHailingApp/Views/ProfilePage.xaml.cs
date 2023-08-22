using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RideHailingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private async void SignOutLbl_Tapped(object sender, EventArgs e)
        {
            var result = await this.DisplayAlert("Sign Out?", "You will be logged out of your account", "Logout", "Cancel");

            if (result.Equals(true))
                await Shell.Current.GoToAsync(state: "//main/signin");
        }

        private async void MyCarLbl_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//Home/carProfilePage");
        }

        private async void WynkPassLbl_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//Home/wynkPass");
        }
    }
}