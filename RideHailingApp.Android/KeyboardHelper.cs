using Android.App;
using Android.Content.Res;
using RideHailingApp.Controls;
using Xamarin.Forms;
using RideHailingApp.Droid;
using Android.Content;

[assembly: Dependency(typeof(KeyboardHelper))]
namespace RideHailingApp.Droid
{
    public class KeyboardHelper : IKeyboardHelper
    {
        public double GetKeyboardHeight()
        {
            var decorView = GetActivity().Window.DecorView;
            var rect = new Android.Graphics.Rect();
            decorView.GetWindowVisibleDisplayFrame(rect);

            var screenHeight = decorView.Height;
            var keyboardHeight = screenHeight - rect.Bottom;

            return keyboardHeight / GetDisplayDensity();
        }

        private Activity GetActivity()
        {
            var context = Android.App.Application.Context;
            while (context is ContextWrapper wrapper)
            {
                if (wrapper is Activity activity)
                {
                    return activity;
                }
                context = wrapper.BaseContext;
            }
            return null;
        }

        private float GetDisplayDensity()
        {
            var metrics = Resources.System.DisplayMetrics;
            return metrics.Density;
        }
    }
}
