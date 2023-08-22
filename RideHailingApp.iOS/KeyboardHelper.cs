using RideHailingApp.Controls;
using UIKit;
using Xamarin.Forms;
using RideHailingApp.iOS;

[assembly: Dependency(typeof(KeyboardHelper))]
namespace RideHailingApp.iOS
{
    public class KeyboardHelper : IKeyboardHelper
    {
        public double GetKeyboardHeight()
        {
            UIWindow window = UIApplication.SharedApplication.KeyWindow;
            UIView rootView = window.RootViewController.View;

            double keyboardHeight = rootView.Frame.Height - rootView.SafeAreaInsets.Bottom;
            return keyboardHeight / GetScreenScale();
        }

        private float GetScreenScale()
        {
            return (float)UIScreen.MainScreen.Scale;
        }
    }
}
