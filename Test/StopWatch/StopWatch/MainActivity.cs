using Android.App;
using Android.Widget;
using Android.OS;
using RadialProgress;
using System.Timers;
using System;
using System.Collections.Generic;

namespace StopWatch
{
    [Activity(Label = "StopWatch", MainLauncher = true)]
    public class MainActivity : Activity
    {

        RadialProgressView radialProgressView;
        Button btnStart, btnStop;
        TextView txtTimer;
        int maxValue = 60;
        Timer timer;
        int hour = 0, min = 0, sec = 0;

        public List<int> TimeLimits = new List<int>
        {5,10,15,20,25,30,45,59};
        cl_Timer myTimer;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            radialProgressView = FindViewById<RadialProgressView>(Resource.Id.progressView);
            btnStart = FindViewById<Button>(Resource.Id.btnStart);
            btnStop = FindViewById<Button>(Resource.Id.btnStop);
            txtTimer = FindViewById<TextView>(Resource.Id.txtTimer);

            myTimer = new cl_Timer(  this,ref btnStart,ref btnStop, ref radialProgressView);

            btnStart.Click += myTimer.BtnStart_Click;
            btnStop.Click += myTimer.BtnStop_Click;

            //btnStart.Click += BtnStart_Click;
            //btnStop.Click += BtnStop_Click;

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer.Dispose();
            timer = null;
        }

        private void BtnStart_Click(object sender, System.EventArgs e)
        {
            Random random = new Random();
            int RandomNumber = random.Next(0, TimeLimits.Count);
            int maxValue = TimeLimits[RandomNumber];
            sec = maxValue;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed2;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {

            sec++;
            if (sec == 60)
            {
                min++;
                sec = 0;
            }
            if (min == 60)
            {
                hour++;
                min = 0;
            }

            RunOnUiThread(() => { txtTimer.Text = $"{hour}:{min}:{sec}"; });
            radialProgressView.Value = sec;
        }

        private void Timer_Elapsed2(object sender, ElapsedEventArgs e)
        {

            sec--;
            if (sec == 00)
            {
                Random random = new Random();
                int RandomNumber = random.Next(0, TimeLimits.Count);
                int maxValue = TimeLimits[RandomNumber];
                sec = maxValue;
            }


            RunOnUiThread(() => { txtTimer.Text = sec.ToString(); });
            radialProgressView.Value = sec;
        }

    }
}

