using Android.App;
using Android.Widget;
using Android.OS;
//using Android.Support.V7.AppCompat;
using Android.Support.V7.Widget;
using Android.Support.V7.App;
using Android.Support.V4.View;
using Android.Views;
 
namespace MaterialDesignTests
{
	[Activity (Label = "Notes Manager", MainLauncher = true)]

//	, Icon = "@mipmap/icon")



	public class MainActivity : AppCompatActivity 
	{
//		int count = 1;

		private Android.Support.V7.Widget.Toolbar mToolbar;
	
		protected override void OnCreate (Bundle savedInstanceState)
		{
			Xamarin.Insights.Initialize (global::MaterialDesignTests.XamarinInsights.ApiKey, this);
			base.OnCreate (savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			mToolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
			SetSupportActionBar (mToolbar);
			SupportActionBar.Title = "Yay for the Notes!";


			// Get our button from the layout resource,
			// and attach an event to it
//			Button button = FindViewById<Button> (Resource.Id.myButton);
//			button.Click += delegate {
//				button.Text = string.Format ("{0} clicks!", count++);
//			};
		}


		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.menu_main, menu);
			return base.OnCreateOptionsMenu(menu);
		}



					//		public   bool onCreateOptionsMenu(Android.Views.IMenu menu) {
					//			Inflate the menu; this adds items to the action bar if it is present.
					//			getMenuInflater().inflate(R.menu.menu_main, menu);
					//			MenuInflater.Inflate(Resource.Menu.menu_main, menu);
					//			return true;
					//		}

//		https://forums.xamarin.com/discussion/5198/how-do-i-create-an-options-menu
//		public override bool OnPrepareOptionsMenu(IMenu menu)
//		{
//			MenuInflater.Inflate(Resource.Menu.menu_main, menu);
//			return base.OnPrepareOptionsMenu(menu);
//		}

					//		public  override bool  onOptionsItemSelected(Android.Views.IMenuItem  item) {
					//			// Handle action bar item clicks here. The action bar will
					//			// automatically handle clicks on the Home/Up button, so long
					//			// as you specify a parent activity in AndroidManifest.xml.
					//			 int id =  SimpleAdapter.GetItemId(item.ItemId);
					//
					//			//noinspection SimplifiableIfStatement
					//			if (id ==Resource.Id.action_settings) {
					//				return true;
					//			}
					//
					//			return   Activity.OnOptionsItemSelected(item);
					//
					//					}
					//
//		public override bool OnOptionsItemSelected(IMenuItem item)
//		{
////			switch (item.ItemId)
////			{
////			case Resource.Id.new_game:
////				//do something
////				return true;
////			case Resource.Id.help:
////				//do something
////				return true;
////			}
//			return base.OnOptionsItemSelected(item);
//		}
	}
}
