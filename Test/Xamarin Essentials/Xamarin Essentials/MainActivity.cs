using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Xamarin.Essentials;

namespace Xamarin_Essentials
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{bool Myswitch=true;

        
        protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_main);

			Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            TextView textview1 = FindViewById<TextView>(Resource.Id.TextView1);
            AccelerometerTest accelerometerTest = new AccelerometerTest(textview1);
            accelerometerTest.ToggleAcceleromter();
            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
		}

		public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            //View view = (View) sender;
            //Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
            //    .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();

            //Myswitch = !Myswitch;
            TextView textview1 = FindViewById<TextView>(Resource.Id.TextView1);
            AccelerometerTest accelerometerTest = new AccelerometerTest(textview1);
            accelerometerTest.ToggleAcceleromter();
            //CompassTest compassTest = new CompassTest(textview1);
            //compassTest.ToggleCompass();

        }

        public class AccelerometerTest
        {
            // Set speed delay for monitoring changes.
            SensorSpeed speed = SensorSpeed.Ui;
            TextView MyTextview;
            public AccelerometerTest(TextView MyTextview)
            {
                // Register for reading changes, be sure to unsubscribe when finished
                Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
                //Accelerometer.Start(SensorSpeed.Ui);
                this.MyTextview = MyTextview;
            }

            public AccelerometerTest()
            {
                // Register for reading changes, be sure to unsubscribe when finished
                Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
                //Accelerometer.Start(SensorSpeed.Ui);
                //this.MyTextview = MyTextview;
            }
            void Start()
            {
                Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
                Accelerometer.Start(SensorSpeed.Ui);
            }
            void Stop()
            {
                Accelerometer.Stop();
                Accelerometer.ReadingChanged -= Accelerometer_ReadingChanged;
                MyTextview.Text = null;
            }

            void Stop(TextView MyTextview)
            {
                Accelerometer.Stop();
                Accelerometer.ReadingChanged -= Accelerometer_ReadingChanged;
                MyTextview.Text = null;
            }
            void Accelerometer_ReadingChanged(AccelerometerChangedEventArgs e)
            {
                var data = e.Reading;
                Console.WriteLine($"Reading: X: {data.Acceleration.X}, Y: {data.Acceleration.Y}, Z: {data.Acceleration.Z}");

                MyTextview.Text = $"Reading: X: {data.Acceleration.X}, Y: {data.Acceleration.Y}, Z: {data.Acceleration.Z}";
                // Process Acceleration X, Y, and Z
            }

            public void ToggleAcceleromter()
            {
                try
                {
                    if (Accelerometer.IsMonitoring)
                        Accelerometer.Stop();
                    else
                        Accelerometer.Start(speed);
                }
                catch (FeatureNotSupportedException fnsEx)
                {
                    // Feature not supported on device
                }
                catch (Exception ex)
                {
                    // Other error has occurred.
                }
            }
        }

        public class CompassTest
        {
            // Set speed delay for monitoring changes.
            SensorSpeed speed = SensorSpeed.Ui;
            TextView MyTextview;
            public CompassTest(TextView MyTextview)
            {
                // Register for reading changes, be sure to unsubscribe when finished
                Compass.ReadingChanged += Compass_ReadingChanged;
            }

            void Compass_ReadingChanged(CompassChangedEventArgs e)
            {
                var data = e.Reading;
                Console.WriteLine($"Reading: {data.HeadingMagneticNorth} degrees");
                 MyTextview.Text= $"Reading: {data.HeadingMagneticNorth} degrees";
                // Process Heading Magnetic North
            }

            public void ToggleCompass()
            {
                try
                {
                    if (Compass.IsMonitoring)
                        Compass.Stop();
                    else
                        Compass.Start(speed);
                }
                catch (FeatureNotSupportedException fnsEx)
                {
                    // Feature not supported on device
                }
                catch (Exception ex)
                {
                    // Some other exception has occured
                }
            }
        }
    }
}

