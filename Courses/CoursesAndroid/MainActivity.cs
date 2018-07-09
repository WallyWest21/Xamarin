using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CoursesAndroid
{
    [Activity(Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button buttonPrev;
        Button buttonNext;
        TextView textTitle;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonPrev = FindViewById<Button>(Resource.Id.buttonNext);
            textTitle = FindViewById<TextView>(Resource.Id.textTitle);

            buttonNext.Click += ButtonNext_Click;
            buttonPrev.Click += ButtonPrev_Click;
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            textTitle.Text = "Prev Clicked";
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            textTitle.Text = "Next Clicked";
        }
    }
}

