using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using RideHailingApp.VIewModels;
using Xamarin.Forms.Xaml;

namespace RideHailingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginOtpPage : ContentPage
    {
        public LoginOtpPage()
        {
            InitializeComponent();

            BindingContext = new LoginOtpPageModel();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//main/signin/loginOTP");
        }

        private async void NavbackBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "..");
        }

        private void FirstEntry_Completed(object sender, EventArgs e)
        {
            SecondEntry.Focus();
        }

        private void SecondEntry_Completed(object sender, EventArgs e)
        {
            ThirdEntry.Focus();
        }

        private void ThirdEntry_Completed(object sender, EventArgs e)
        {
            FourthEntry.Focus();
        }
    }
}