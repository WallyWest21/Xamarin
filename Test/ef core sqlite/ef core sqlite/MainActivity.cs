using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using ef_repo_sqlite_NET;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ef_core_sqlite
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
        int count = 1;

         
        protected async override void OnCreate(Bundle savedInstanceState)
		{

            base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_main);

			//Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);

			//FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
   //         fab.Click += FabOnClick;
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate {

            //    button.Text = string.Format("{0} clicks!", count++);
                                            
            //};

            button.Click += buttonOnClick;

            TextView textView = FindViewById<TextView>(Resource.Id.TextView1);

            var dbFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var fileName = "Cats.db";
            var dbFullPath = Path.Combine(dbFolder, fileName);
            try
            {
                using (var db = new TaskContext (dbFullPath))
                {
                    await db.Database.MigrateAsync(); //We need to ensure the latest Migration was added. This is different than EnsureDatabaseCreated.

                    Task catGary = new Task() { Id = 1, Description = "Gary" };
                    Task catJack = new Task() { Id = 2, Description = "Jack" };
                    Task catLuna = new Task() { Id = 3, Description = "Luna"};

                    List<Task> TaskList = new List<Task>() { catGary, catJack, catLuna };

                    if (await db.Tasks.CountAsync() < 3)
                    {
                        await db.Tasks.AddRangeAsync(TaskList);
                        await db.SaveChangesAsync();
                    }

                    var dbALLTaskList = await db.Tasks.ToListAsync();

                    foreach (Task task in dbALLTaskList)
                    {
                        textView.Text += $"{task.Id} - {task.Description}" + System.Environment.NewLine;
                    }
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
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

        private async void buttonOnClick(object sender, EventArgs eventArgs)
        {
            //View view = (View)sender;
            //Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
            //    .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
            Button button = (Button)sender;
            button.Text = string.Format("{0} clicks!", count++);
            TextView textView = FindViewById<TextView>(Resource.Id.TextView1);

            var dbFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var fileName = "Cats.db";
            var dbFullPath = Path.Combine(dbFolder, fileName);
            try
            {
                using (var db = new TaskContext(dbFullPath))
                {
                    await db.Database.MigrateAsync(); //We need to ensure the latest Migration was added. This is different than EnsureDatabaseCreated.

                    Task catGary = new Task() { Id = 1, Description = "Gary" };
                    Task catJack = new Task() { Id = 2, Description = "Jack" };
                    Task catLuna = new Task() { Id = 3, Description = "Luna" };

                    List<Task> TaskList = new List<Task>() { catGary, catJack, catLuna };

                    if (await db.Tasks.CountAsync() < 3)
                    {
                        await db.Tasks.AddRangeAsync(TaskList);
                        await db.SaveChangesAsync();
                    }

                    var dbALLTaskList = await db.Tasks.ToListAsync();

                    foreach (Task task in dbALLTaskList)
                    {
                        textView.Text += $"{task.Id} - {task.Description}" + System.Environment.NewLine;
                    }
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

        }
    }
}

