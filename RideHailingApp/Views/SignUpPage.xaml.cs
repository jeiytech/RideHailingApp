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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private async void NavbackBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "..");
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "..");
        }

        private async void ContinueBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//main/signin/registration/personalPage");
        }
    }
}