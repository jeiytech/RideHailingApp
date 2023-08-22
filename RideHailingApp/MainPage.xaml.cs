using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RideHailingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//main/signin");
        }

        private async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//main/registration");
        }
    }
}
