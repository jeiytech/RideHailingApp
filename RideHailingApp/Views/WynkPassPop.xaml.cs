using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RideHailingApp.Views;
using RideHailingApp.DataModel;
using Rg.Plugins.Popup.Services;

namespace RideHailingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WynkPassPop : Rg.Plugins.Popup.Pages.PopupPage
    {
        public WynkPassPop()
        {
            InitializeComponent();

            /*PassName.Text = name;
            PassValid.Text = valid;*/
            overall.BackgroundColor = new Color(0, 0, 0, 0.7);
        }

        private void ProceedBtn_Clicked(object sender, EventArgs e)
        {
            overall.IsVisible = false;
            PopupNavigation.Instance.PushAsync(new PaymentMethodPage());
        }

        private void CancelLbl_Tapped(object sender, EventArgs e)
        {
            overall.IsVisible = false;
        }
    }
}