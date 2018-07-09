using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Hardware;

namespace ShakeMotionTest.ViewModel
{
    public class Hardware
    {
        public class ShakeDetection
        {
            bool hasUpdated = false;
            DateTime lastUpdate;
            float last_x = 0.0f;
            float last_y = 0.0f;
            float last_z = 0.0f;

            const int ShakeDetectionTimeLapse = 250;
            const double ShakeThreshold = 800;
            MainActivity mainActivity;

            public ShakeDetection(MainActivity mainActivity)
            {
                this.mainActivity = mainActivity;
            }

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

                            if (speed > ShakeThreshold)
                            {
                                Toast.MakeText(mainActivity, "shake detected w/ speed: " + speed, ToastLength.Short).Show();
                            }

                            last_x = x;
                            last_y = y;
                            last_z = z;
                        }
                    }
                }
            }
        }

    }
}