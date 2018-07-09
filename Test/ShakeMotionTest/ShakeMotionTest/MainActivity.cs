using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Hardware;
using Android.Runtime;
using ClassLibrary1;
using System.Timers;
using System.Collections.Generic;

namespace ShakeMotionTest
{
    //https://stackoverflow.com/questions/23120186/can-xamarin-handle-shake-accelerometer-on-android/23146330
    [Activity(Label = "ShakeMotionTest", MainLauncher = true)]
    public class MainActivity : Activity, Android.Hardware.ISensorEventListener
    {
        Sexy8Ball s8Ball = new Sexy8Ball();
        Class1 MyNewClass = new Class1();

        bool hasUpdated = false;
        DateTime lastUpdate;
        float last_x = 0.0f;
        float last_y = 0.0f;
        float last_z = 0.0f;
        int counter = 0;

        const int ShakeDetectionTimeLapse = 250;
        const double ShakeThreshold = 500;
        const double FilthyShakeThreshold = 1200;

        TextView ActionsTextView;
        TextView BodyPartsTextView;
        TextView CountdownTextView;

        int maxTimerValue = 60;
        Timer timer;
        int hour = 0, min = 0, sec = 0;
        //public List<int> TimeLimits = new List<int> { 5, 10, 15, 20, 25, 30, 45, 59 };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

             ActionsTextView = FindViewById<TextView>(Resource.Id.textViewActions);
             BodyPartsTextView = FindViewById<TextView>(Resource.Id.textViewBodyParts);

            ActionsTextView.Text = s8Ball.GetAction();
            BodyPartsTextView.Text = s8Ball.GetBodyPart();

            // Register this as a listener with the underlying service.
            var sensorManager = GetSystemService(SensorService) as Android.Hardware.SensorManager;
            var sensor = sensorManager.GetDefaultSensor(Android.Hardware.SensorType.Accelerometer);
            sensorManager.RegisterListener(this, sensor, Android.Hardware.SensorDelay.Game);

            //StarTimer();
        }
        #region Android.Hardware.ISensorEventListener implementation
        public void OnAccuracyChanged(Android.Hardware.Sensor sensor, Android.Hardware.SensorStatus accuracy)
        {
        }

        public void OnSensorChanged(Android.Hardware.SensorEvent e)
        {
            if (e.Sensor.Type == Android.Hardware.SensorType.Accelerometer)
            {
                float x = e.Values[0];
                float y = e.Values[1];
                float z = e.Values[2];

                DateTime curTime = System.DateTime.Now;
                if (hasUpdated == false)
                {
                    hasUpdated = true;
                    lastUpdate = curTime;
                    last_x = x;
                    last_y = y;
                    last_z = z;
                }
                else
                {
                    if ((curTime - lastUpdate).TotalMilliseconds > ShakeDetectionTimeLapse)
                    {
                        float diffTime = (float)(curTime - lastUpdate).TotalMilliseconds;
                        lastUpdate = curTime;
                        float total = x + y + z - last_x - last_y - last_z;
                        float speed = Math.Abs(total) / diffTime * 10000;

                         if (speed > FilthyShakeThreshold)
                        {
                            Toast.MakeText(this, "shake detected w/ speed: " + speed, ToastLength.Short).Show();
                            //counter = counter + 1;
                            //TextView CounterTxtView = FindViewById<TextView>(Resource.Id.textViewCounter);
                            //CounterTxtView.Text = counter.ToString();

                            ActionsTextView.Text = s8Ball.GetAction();
                            BodyPartsTextView.Text = s8Ball.GetFilthyBodyPart();

                        }
                        else if (speed > ShakeThreshold)
                        {
                            Toast.MakeText(this, "shake detected w/ speed: " + speed, ToastLength.Short).Show();
                            //counter = counter + 1;
                            //TextView CounterTxtView = FindViewById<TextView>(Resource.Id.textViewCounter);
                            //CounterTxtView.Text = counter.ToString();
                            
                            ActionsTextView.Text = s8Ball.GetAction();
                            BodyPartsTextView.Text = s8Ball.GetBodyPart();



                        }


                        last_x = x;
                        last_y = y;
                        last_z = z;
                    }
                }
            }
        }

        #endregion

        //#region Timer

        //public void StarTimer()
        //{
        //    Random random = new Random();
        //    int RandomNumber = random.Next(0, TimeLimits.Count);
        //    maxTimerValue = TimeLimits[RandomNumber];
        //    sec = maxTimerValue;

        //    timer = new Timer();
        //    timer.Interval = 1000;
        //    timer.Elapsed += CoutDownTimer;
        //    timer.Start();
        //}

        //public void StopTimer()
        //{
        //    timer.Dispose();
        //    timer = null;
        //}

        //private void CoutDownTimer(object sender, ElapsedEventArgs e)
        //{
        //    sec--;
        //    if (sec == 00)
        //    {
        //        Random random = new Random();
        //        int RandomNumber = random.Next(0, TimeLimits.Count);
        //        maxTimerValue = TimeLimits[RandomNumber];
        //        sec = maxTimerValue;
        //    }

        //    RunOnUiThread(() => { CountdownTextView.Text = sec.ToString(); });
        //    //radialProgressView.Value = sec;
        //}

        //#endregion
    }

}