using RideHailingApp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RideHailingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        private double originalStackLayoutHeight;
        private double keyboardHeight;
        private double originalPageHeight;
        public ChatPage()
        {
            InitializeComponent();
            NewMessageEntry.FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label));
            originalStackLayoutHeight = ChatLayout.Height;
            originalPageHeight = App.Current.MainPage.Height;

            // Subscribe to keyboard visibility changes
            MessagingCenter.Subscribe<App, bool>(this, "KeyboardVisibilityChanged", OnKeyboardVisibilityChanged);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            // Unsubscribe from keyboard visibility changes
            MessagingCenter.Unsubscribe<App, bool>(this, "KeyboardVisibilityChanged");
        }

        private void OnKeyboardVisibilityChanged(App app, bool isKeyboardVisible)
        {
            ChatLayout.BackgroundColor = Color.Green;
            if (isKeyboardVisible)
            {
                double keyboardHeight = 0;

                if (Device.RuntimePlatform == Device.Android || Device.RuntimePlatform == Device.iOS)
                {
                    keyboardHeight = DependencyService.Get<IKeyboardHelper>().GetKeyboardHeight();
                }

                // Reduce the stack layout height by the keyboard height
                App.Current.MainPage.HeightRequest = originalPageHeight - keyboardHeight;
                ChatLayout.BackgroundColor = Color.Green;
            }
            else
            {
                // Restore the original stack layout height
                ChatLayout.HeightRequest = originalPageHeight;
            }
        }



        private async void CloseMessage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//Home");
        }

        protected override bool OnBackButtonPressed()
        {
            // Add your navigation logic here
            // For example, navigate back to the previous page:
            Shell.Current.GoToAsync(state: "//Home");

            // Return true to indicate that you have handled the back button press
            return true;
        }


        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            string message = NewMessageEntry.Text;

            if (string.IsNullOrWhiteSpace(message))
            {
                DisplayAlert("Empty Message", "Please enter a message", "OK");
                return;
            }

            NewMessageEntry.Text = "";

            Label chatText = new Label
            {
                Text = message,
                FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
                Padding = new Thickness(-5, 0, -5, 0),
                TextColor = Color.FromHex("#FFFFFF"),
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
                FontAttributes = FontAttributes.None,
                FontFamily = Device.GetNamedSize(NamedSize.Default, typeof(Label)).ToString(),
                LineBreakMode = LineBreakMode.WordWrap
            };

            if (message.Length > 40)
            {
                chatText.WidthRequest = 300;
            }

            Frame chatFrame = new Frame
            {
                Content = chatText,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                Padding = new Thickness(15, 8, 15, 8),
                Margin = new Thickness(2),
                BackgroundColor = Color.FromHex("#5A89FF"),
                CornerRadius = 10,
                BorderColor = Color.FromHex("#5A89FF"),
                HasShadow = true
            };

            // Add entry animation
            chatFrame.TranslationX = 200;
            chatFrame.Opacity = 0;
            chatFrame.Scale = 0.5;

            ChatStackLayout.Children.Add(chatFrame);

            // Start entry animation
            chatFrame.TranslateTo(0, 0, 250, Easing.SinOut);
            chatFrame.FadeTo(1, 250);
            chatFrame.ScaleTo(1, 250);

            // Optional: Scroll to the latest chat message
            // Optional: Scroll to the latest chat message
            Device.BeginInvokeOnMainThread(async () =>
            {
                await Task.Delay(100); // Delay the scrolling operation for 100 milliseconds
                await MainScrollView.ScrollToAsync(chatFrame, ScrollToPosition.End, true);
            });


        }


        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            string message = NewMessageEntry.Text;

            if (string.IsNullOrWhiteSpace(message))
            {
                DisplayAlert("Empty Message", "Please enter a message", "OK");
                return;
            }

            NewMessageEntry.Text = "";

            Label chatText = new Label
            {
                Text = message,
                FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
                Padding = new Thickness(-5, 0, -5, 0),
                TextColor = Color.FromHex("#7C7C7C"),
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
                FontAttributes = FontAttributes.None,
                FontFamily = Device.GetNamedSize(NamedSize.Default, typeof(Label)).ToString(),
                LineBreakMode = LineBreakMode.WordWrap
            };

            if (message.Length > 40)
            {
                chatText.WidthRequest = 300;
            }

            Frame chatFrame = new Frame
            {
                Content = chatText,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(15, 8, 15, 8),
                Margin = new Thickness(2),
                BackgroundColor = Color.FromHex("#FFFFFF"),
                CornerRadius = 10,
                BorderColor = Color.FromHex("#FFFFFF"),
                HasShadow = true
            };

            // Add entry animation
            chatFrame.TranslationX = -200;
            chatFrame.Opacity = 0;
            chatFrame.Scale = 0.5;

            ChatStackLayout.Children.Add(chatFrame);

            // Start entry animation
            chatFrame.TranslateTo(0, 0, 250, Easing.SinOut);
            chatFrame.FadeTo(1, 250);
            chatFrame.ScaleTo(1, 250);

            // Optional: Scroll to the latest chat message
            // Optional: Scroll to the latest chat message
            Device.BeginInvokeOnMainThread(async () =>
            {
                await Task.Delay(100); // Delay the scrolling operation for 100 milliseconds
                await MainScrollView.ScrollToAsync(chatFrame, ScrollToPosition.End, true);
            });

        }
    }
}