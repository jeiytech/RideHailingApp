using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RideHailingApp.VIewModels
{
    class PhoneDialerViewModel
    {
        public void DialNumber(string number)
        {
            try
            {
                PhoneDialer.Open(number);
            }
            catch (ArgumentNullException anEx)
            {
                Console.WriteLine(anEx.Message);
            }
            catch(FeatureNotEnabledException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
