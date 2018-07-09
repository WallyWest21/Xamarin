using Android.App;
using Android.Widget;
using Android.OS;

namespace MaterialDesignV2
{
//	[Activity (Label = "Material Design V2", MainLauncher = true, Icon = "@mipmap/icon")]

	[Activity(MainLauncher = true)]

	public class MainActivity : Activity
	{
//		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			Xamarin.Insights.Initialize (global::MaterialDesignV2.XamarinInsights.ApiKey, this);
			base.OnCreate (savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			// Get our button from the layout resource,
			// and attach an event to it
//			Button button = FindViewById<Button> (Resource.Id.myButton);
//			button.Click += delegate {
//				button.Text = string.Format ("{0} clicks!", count++);
//			};
		}
	}
}
