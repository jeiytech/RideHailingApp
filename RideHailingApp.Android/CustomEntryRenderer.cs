using Android.Content;
using Android.Views.InputMethods;
using RideHailingApp.Controls;
using RideHailingApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace RideHailingApp.Droid.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == VisualElement.IsFocusedProperty.PropertyName)
            {
                if (Control != null)
                {
                    if (Control.IsFocused)
                    {
                        Control.Post(() =>
                        {
                            InputMethodManager imm = (InputMethodManager)Context.GetSystemService(Context.InputMethodService);
                            imm.ToggleSoftInput(ShowFlags.Forced, HideSoftInputFlags.ImplicitOnly);
                        });
                    }
                    else
                    {
                        Control.Post(() =>
                        {
                            InputMethodManager imm = (InputMethodManager)Context.GetSystemService(Context.InputMethodService);
                            imm.HideSoftInputFromWindow(Control.WindowToken, 0);
                        });
                    }
                }
            }
        }
    }
}
