using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;

namespace RideHailingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CancelRidePop : Rg.Plugins.Popup.Pages.PopupPage
    {
        public CancelRidePop()
        {
            InitializeComponent();
            overall.BackgroundColor = new Color(0, 0, 0, 0.8);
        }

        private void CancelLbl_Tapped(object sender, EventArgs e)
        {
            overall.IsVisible = false;
        }
    }
}