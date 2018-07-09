using Android.App;
using Android.Widget;
using Android.OS;
using System.Timers;
using System;

//https://www.youtube.com/watch?v=PI34_Y-uxVM&t=304s
namespace TimerTask
{
    [Activity(Label = "TimerTask", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button btnCancel;
        private TextView txtCountdown;
        private int count = 1;
        Timer timer;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            btnCancel = FindViewById<Button>(Resource.Id.btnCancel);
            txtCountdown = FindViewById<TextView>(Resource.Id.txtCountDown);
            btnCancel.Click += BtnCancel_Click;


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtCountdown.Text = "Stop";
            timer.Stop();
        }

        protected override void OnResume()
        {
            base.OnResume();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (count < 10)
            {
                count++;
                RunOnUiThread(() =>
                {
                    txtCountdown.Text = "" + count;
                }


                );

            }
            else
            {
                count = 1;
                Toast.MakeText(this, "Hello", ToastLength.Short).Show();
                txtCountdown.Text = "" + count;
            }
        }
    }
}

