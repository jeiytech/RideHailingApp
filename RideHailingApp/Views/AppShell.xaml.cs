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
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Routings that end with "Pop" are not passed as a content page,
            //hence they are not called with their route: "Names"
            Routing.RegisterRoute(route: "registration", typeof(SignUpPage));
            Routing.RegisterRoute(route: "signin", typeof(SignInPage));
            Routing.RegisterRoute(route: "loginOTP", typeof(LoginOtpPage));
            Routing.RegisterRoute(route: "forgotPass", typeof(ForgotPassword));
            Routing.RegisterRoute(route: "resetPass", typeof(ResetPassword));
            Routing.RegisterRoute(route: "personalPage", typeof(PersonalDetailsPage));
            Routing.RegisterRoute(route: "carPage", typeof(CarDetailsPage));
            Routing.RegisterRoute(route: "paymentPage", typeof(PaymentDetailsPage));

            Routing.RegisterRoute(route: "carProfilePage", typeof(CarProfilePage));
            Routing.RegisterRoute(route: "wynkPass", typeof(WynkPassPage));
            Routing.RegisterRoute(route: "wynkPassPop", typeof(WynkPassPop));
            Routing.RegisterRoute(route: "paymentMethod", typeof(PaymentMethodPage));
            Routing.RegisterRoute(route: "cancelRidePop", typeof(CancelRidePop));
            Routing.RegisterRoute(route: "startTrip", typeof(verifyRidePop));
        }
    }

    public class HiddenItem : ShellItem
    {

    }
}