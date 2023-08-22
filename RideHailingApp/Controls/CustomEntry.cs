using Xamarin.Forms;

namespace RideHailingApp.Controls
{
    public class CustomEntry : Entry
    {
        public static new readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomEntry), null,
                propertyChanged: OnTextChanged);

        public new string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        private static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Handle any custom logic when the Text property changes
        }
    }
}
