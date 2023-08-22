using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;
using RideHailingApp.VIewModels;
using System.Threading.Tasks;

namespace RideHailingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriverDashboardOfflinePage : ContentPage
    {
        public DriverDashboardOfflinePage()
        {
            InitializeComponent();
            findRider.IsVisible = false;
            GoLine.IsVisible = false;
            driverRequest.IsVisible = false;
            //driverArrived.IsVisible = false;
            CallingMode.IsVisible = false;
            overall.IsVisible = true;
        }

        private void GoOnlineLbl_Tapped(object sender, EventArgs e)
        {
            GoLine.IsVisible = false;
            findRider.IsVisible = true;        }

        private void GoOfflineBtn_Clicked(object sender, EventArgs e)
        {
            findRider.IsVisible = false;
            GoLine.IsVisible = true;
        }

        private async void cancelRideBtn_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new CancelRidePop());
        }

        private async void StartTripLbl_Tapped(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new verifyRidePop());
        }

        private void MakePhoneCall(string phoneNumber)
        {
            PhoneDialerViewModel viewModel = new PhoneDialerViewModel();
            viewModel.DialNumber(phoneNumber);
        }

        private async void callBtn_Clicked(object sender, EventArgs e)
        {
            driverArrived.IsVisible = false;
            over.Spacing = -250;
            CallingMode.IsVisible = true;
            string phoneNumber = "08132066864";

            if (string.IsNullOrEmpty(phoneNumber))
            {
                await DisplayAlert("Error","Please enter a valid phone number.", "OK");
                return;
            }

            MakePhoneCall(phoneNumber);
        }

        private void EndCallBtn_Clicked(object sender, EventArgs e)
        {
            driverArrived.IsVisible = true;
            over.Spacing = -210;
            CallingMode.IsVisible = false;
        }

        private async void messageBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//chatPage");
        }
    }
}