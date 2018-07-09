using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RadialProgress;

namespace StopWatch
{
    class cl_Timer 
    {
        RadialProgressView radialProgressView;
        Button btnStart, btnStop;
        TextView txtTimer;
        //int maxValue = 60;
        Timer timer;
        int hour = 0, min = 0, sec = 0;
        public List<int> TimeLimits = new List<int>{5,10,15,20,25,30,45,59};
        Activity MyActivity;

        int maxTimerValue;
        public cl_Timer(Activity MyActivity)
        {
            this.MyActivity = MyActivity;
        }

        public cl_Timer( Context MyActivity, ref Button btnStart, ref Button btnStop,ref RadialProgressView radialProgressView)
        {
            this.MyActivity = (Activity)MyActivity;
            this.btnStart = btnStart;
            this.btnStop = btnStop;
            this.radialProgressView = radialProgressView;
        }

        public cl_Timer(Activity MyActivity, Button btnStart, Button btnStop)
        {
            this.MyActivity = MyActivity;
            this.btnStart = btnStart;
            this.btnStop = btnStop;
        }

        public void  StarTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += CoutDownTimer;
            timer.Start();
        }
    
        public void StopTimer()
        {
            timer.Dispose();
            timer = null;
        }

        public void BtnStart_Click(object sender, System.EventArgs e)
        {
            Random random = new Random();
            int RandomNumber = random.Next(0, TimeLimits.Count);
            maxTimerValue = TimeLimits[RandomNumber];
            sec = maxTimerValue;
            StarTimer();
                  }

        public void BtnStop_Click(object sender, EventArgs e)
        {
            StopTimer();
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

            MyActivity.RunOnUiThread(() => { txtTimer.Text = $"{hour}:{min}:{sec}"; });
            radialProgressView.Value = sec;
        }

        private void CoutDownTimer(object sender, ElapsedEventArgs e )
        {
            sec--;
            if (sec == 00)
            {
                Random random = new Random();
                int RandomNumber = random.Next(0, TimeLimits.Count);
                maxTimerValue = TimeLimits[RandomNumber];
                sec = maxTimerValue;
            }

            MyActivity.RunOnUiThread(() => { txtTimer.Text = sec.ToString(); });
            radialProgressView.Value = sec;
        }
    }
}
