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
    public partial class PaymentMethodPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        public PaymentMethodPage()
        {
            InitializeComponent();

            overlay.BackgroundColor = new Color(0, 0, 0, 0.9);
            PayCardCheck.IsVisible = false;
            BankTransferCheck.IsVisible = false;
        }

        private void ClosePaymentBtn_Clicked(object sender, EventArgs e)
        {
            overlay.IsVisible = false;
        }

        private void BankTranferLbl_Tapped(object sender, EventArgs e)
        {
            PayWalletCheck.IsVisible = false;
            PayCardCheck.IsVisible = false;
            BankTransferCheck.IsVisible = true;
        }

        private void PayCardLbl_Tapped(object sender, EventArgs e)
        {
            PayWalletCheck.IsVisible = false;
            BankTransferCheck.IsVisible = false;
            PayCardCheck.IsVisible = true;
        }

        private void PayWalletLbl_Tapped(object sender, EventArgs e)
        {
            BankTransferCheck.IsVisible = false;
            PayCardCheck.IsVisible = false;
            PayWalletCheck.IsVisible = true;
        }

        private async void PayNowBtn_Clicked(object sender, EventArgs e)
        {
            overlay.IsVisible = false;
            await Shell.Current.GoToAsync(state: "//WynkpasssuccessPage");
        }
    }
}