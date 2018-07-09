using System;

using Xamarin.Forms;

namespace ApplicationCatalog
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			var tabs = new TabbedPage ();

			// demonstrates the map control with zooming and map-types
			tabs.Children.Add (new CATIA_2D {Title = "CATIA 2D" });

			// demonstrates the map control with zooming and map-types
			tabs.Children.Add (new CATIA_3D {Title = "CATIA 3D"});

			// demonstrates the Geocoder class
			tabs.Children.Add (new Design {Title = "Design", });

			MainPage = tabs;
//			var np = new NavigationPage( 
//
//				
//				MainPage = new ContentPage
//
//				{Title = "application catalog",
//
//					
//					Content= new CarouselPage
//					{
//						Children={CATIA_2D ,CATIA_3D, Design }
//					};
//
//
//				}
//					);
				
			


		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

