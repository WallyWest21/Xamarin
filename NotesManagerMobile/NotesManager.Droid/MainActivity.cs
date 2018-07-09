using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace NotesManager.Droid
{
	[Activity (Label = "Notes Manager.Droid", 
		MainLauncher = true, Icon = "@mipmap/icon")]

	public class MainActivity : AppCompatActivity
	{

		protected override void OnCreate (Bundle bundle)
		{
			Xamarin.Insights.Initialize (global::NotesManager.Droid.XamarinInsights.ApiKey, this);
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);
			SetSupportActionBar (toolbar);
			SupportActionBar.Title = "Notes Manager";


		}

		//		/// <Docs>The options menu in which you place your items.</Docs>
		/// <returns>To be added.</returns>
		/// <summary>
		/// This is the menu for the Toolbar/Action Bar to use
		/// </summary>
		/// <param name="menu">Menu.</param>
		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			MenuInflater.Inflate (Resource.Menu.home, menu);
			return base.OnCreateOptionsMenu (menu);
		}
		public override bool OnOptionsItemSelected (IMenuItem item)
		{	
			Toast.MakeText(this, "Top ActionBar pressed: " + item.TitleFormatted, ToastLength.Short).Show();
			return base.OnOptionsItemSelected (item);
		}
	}
}
