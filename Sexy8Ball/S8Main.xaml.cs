using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DeviceMotion.Plugin.Abstractions;

using Xamarin.Forms;

namespace Sexy8Ball
{


	public partial class S8Main : ContentPage
	{

		public static List<string> Actions = new List<string>
		{"Lick", "Suck", "Blow", "Kiss", "Stare", "Wild", "Touch", "Bite", "Massage", "Fondle", "Stroke"};

		public static List<string> BodyParts = new List<string>
		{"Elbow","Toes","Face", "Feet", "Hand", "Upper Body","Arms", "Legs",
			"Lower Body", "Lips", "Ear",  "Eyes" ,"Back","Shoulders","Hair",
			"Thigh", "Groin", "Ass", "Neck", "Nipple", "Belly Button", "Knee", "Wild", "Whole Body"};
	

		public S8Main ()
		{
			InitializeComponent ();
//			btn_TouchMe.SetAllCaps (false);
//			button.SetAllCaps(false);

//			CrossDeviceMotion.Current.Start (MotionSensorType.Accelerometer);
//			CrossDeviceMotion.Current.SensorValueChanged += (s, a) => {
//
//				switch (a.SensorType) {
//
//				case MotionSensorType.Accelerometer:
//					Debug.WriteLine ("A: {0},{1},{2}", ((MotionVector)a.Value).X, ((MotionVector)a.Value).Y, ((MotionVector)a.Value).Z);
//
//					break;
//
//				}
//			};

		}
//		private void button_Click()
//		{
//			Random random = new Random();
//			int randomNumber = random.Next(0, Actions.Count);
//
//			Random random1 = new Random();
//			int randomNumber1 = random.Next(0, BodyParts.Count);
//
//			lb_Actions.Text = Actions [randomNumber];
//			lb_BodyParts.Text = BodyParts [randomNumber1];
//		}

		 void OnButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;
//			await DisplayAlert("Clicked!",
//				"The button labeled '" + button.Text + "' has been clicked",
//				"OK");




			Random random = new Random();
			int randomNumber = random.Next(0, Actions.Count);

			Random random1 = new Random();
			int randomNumber1 = random.Next(0, BodyParts.Count);

			lb_Actions.Text = Actions [randomNumber];
			lb_BodyParts.Text = BodyParts [randomNumber1];
		}

	}




}

