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
    public partial class verifyRidePop : Rg.Plugins.Popup.Pages.PopupPage
    {
        public verifyRidePop()
        {
            InitializeComponent();
            overall.BackgroundColor = new Color(0, 0, 0, 0.8);
        }

        private void CloseVerifyTripBtn_Clicked(object sender, EventArgs e)
        {
            overall.IsVisible = false;
        }
    }
}