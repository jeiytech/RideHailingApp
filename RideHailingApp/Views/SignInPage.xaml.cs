using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RideHailingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private async void NavbackBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "..");
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//main/signin/registration");
        }

        private async void LoginOtpBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//main/signin/loginOTP");
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//main/signin/forgotPass");
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//Home");
        }
    }
}