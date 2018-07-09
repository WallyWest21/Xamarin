using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ApplicationCatalog.Droid
{
	[Activity (Label = "ApplicationCatalog.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			Xamarin.Insights.Initialize (global::ApplicationCatalog.Droid.XamarinInsights.ApiKey, this);
			base.OnCreate (bundle);
			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new App ());

			CATIA_2D.ScreenWidth = (int)Resources.DisplayMetrics.WidthPixels; // real pixels
			CATIA_2D.ScreenHeight = (int)Resources.DisplayMetrics.HeightPixels; // real pixels

			// App.ScreenWidth = (int)(Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density); // device independent pixels
			// App.ScreenHeight = (int)(Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density); // device independent pixels

		}


	}

}
