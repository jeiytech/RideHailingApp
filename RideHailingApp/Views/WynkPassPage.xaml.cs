using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RideHailingApp.DataModel;
using System.Timers;

namespace RideHailingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WynkPassPage : ContentPage
    {
        public WynkPassPage()
        {
            InitializeComponent();

           List<WynkPass> myList = new List<WynkPass>
            {
                new WynkPass{PassName = "Wynk Purple", Validity="Valid for 7 days", Image="wynkPurple"},
                new WynkPass{PassName = "Wynk Maverick", Validity="Valid for 30 days", Image="wynkMaverick"},
                new WynkPass{PassName = "Wynk Gold", Validity="Valid for 90 days", Image="wynkGold"}
            };

            MyListView.ItemsSource = myList;
        }

        private async void BackBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "..");
            /*DateTime myDate = new DateTime();
            int year = myDate.Year;
            int month = myDate.Month;*/
        }

        private async void MyListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var wynkpass = e.CurrentSelection[0] as WynkPass;
            var wynkpassPage = new WynkPassPop();
            wynkpassPage.BindingContext = wynkpass;
            if(wynkpass != null)
                await PopupNavigation.Instance.PushAsync(wynkpassPage);
        }

        /*private void SusWynkPurple_Clicked(object sender, EventArgs e)
        {
           PopupNavigation.Instance.PushAsync(new WynkPassPop());
        }*/

    }
}