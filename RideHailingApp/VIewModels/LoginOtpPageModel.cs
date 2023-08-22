using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.ComponentModel;
using System.Diagnostics;
using System.Timers;

namespace RideHailingApp.VIewModels
{
    public class LoginOtpPageModel : INotifyPropertyChanged
    {

        Stopwatch stopWatch = new Stopwatch();
       /* private Timer time = new Timer();
        private bool timerRunning;*/

        private string _stopWatchHours;
        public string StopWatchHours
        {
            get { return _stopWatchHours; }
            set
            {
                _stopWatchHours = value;
                OnPropertyChanged("StopWatchHours");
            }
        }

        private string _stopWatchMinutes ;
        public string StopWatchMinutes
        {
            get { return _stopWatchMinutes; }
            set
            {
                _stopWatchMinutes = value;
                OnPropertyChanged("StopWatchMinutes");
            }
        }

        private string _stopWatchSeconds;
        public string StopWatchSeconds
        {
            get { return _stopWatchSeconds; }
            set
            {
                _stopWatchSeconds = value;
                OnPropertyChanged("StopWatchSeconds");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if(changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public LoginOtpPageModel()
        {
            stopWatch.Start();
            StopWatchHours = stopWatch.Elapsed.Hours.ToString();
            StopWatchMinutes = stopWatch.Elapsed.Minutes.ToString();
            StopWatchSeconds = stopWatch.Elapsed.Seconds.ToString();

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                StopWatchHours = stopWatch.Elapsed.Hours.ToString();
                StopWatchMinutes = stopWatch.Elapsed.Minutes.ToString();
                StopWatchSeconds = stopWatch.Elapsed.Seconds.ToString();

                if (StopWatchMinutes == "2")
                {
                    return false;
                }
                return true;
            });
        }
    }
}
