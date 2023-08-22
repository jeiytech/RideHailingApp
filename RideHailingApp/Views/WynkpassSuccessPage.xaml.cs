using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RideHailingApp.Views;
using RideHailingApp.DataModel;

namespace RideHailingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WynkpassSuccessPage : ContentPage
    {
        public WynkpassSuccessPage()
        {
            InitializeComponent();
        }

        private async void TakeToLoginBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//Home/wynkPass");
        }
    }
}