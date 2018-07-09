using System;
using SupportActionBarDrawerToggle = Android.Support.V7.App.ActionBarDrawerToggle;
using Android.Support.V7.App;
using Android.Support.V4.Widget;

namespace DrawerLayout_V7_Tutorial
{
	public class MyActionBarDrawerToggle : SupportActionBarDrawerToggle
	{
		private AppCompatActivity mHostActivity;
		private int mOpenedResource;
		private int mClosedResource;

		public MyActionBarDrawerToggle (AppCompatActivity host, DrawerLayout drawerLayout, int openedResource, int closedResource) 
			: base(host, drawerLayout, openedResource, closedResource)
		{
			mHostActivity = host;
			mOpenedResource = openedResource;
			mClosedResource = closedResource;
		}

		public override void OnDrawerOpened (Android.Views.View drawerView)
		{	
			int drawerType = (int)drawerView.Tag;

			if (drawerType == 0)
			{
				base.OnDrawerOpened (drawerView);
				mHostActivity.SupportActionBar.SetTitle(mOpenedResource);
			}
		}

		public override void OnDrawerClosed (Android.Views.View drawerView)
		{
			int drawerType = (int)drawerView.Tag;

			if (drawerType == 0)
			{
				base.OnDrawerClosed (drawerView);
				mHostActivity.SupportActionBar.SetTitle(mClosedResource);
			}				
		}

		public override void OnDrawerSlide (Android.Views.View drawerView, float slideOffset)
		{
			int drawerType = (int)drawerView.Tag;

			if (drawerType == 0)
			{
				base.OnDrawerSlide (drawerView, slideOffset);
			}
		}
	}
}














//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//
//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//
//namespace MaterialDesignTests
//{
//	[Activity (Label = "MyActionBarDrawerToggle")]			
//	public class MyActionBarDrawerToggle : Activity
//	{
//		protected override void OnCreate (Bundle savedInstanceState)
//		{
//			base.OnCreate (savedInstanceState);
//
//			// Create your application here
//		}
//	}
//}

