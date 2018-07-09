using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace ApplicationCatalog
{
	public partial class CATIA_3D : ContentPage
	{
		private ObservableCollection<User> users = new ObservableCollection<User>();
		public ObservableCollection<string> TileColorList = new ObservableCollection<string>
		{   "DarkBlue",
			"DarkCyan",
			"DarkGoldenrod",
			"DarkGray",
			"DarkGreen",
			"DarkKhaki",
			"DarkMagenta",
			"DarkOliveGreen",
			"DarkOrange",
			"DarkOrchid",
			"DarkRed",
			"DarkSalmon",
			"DarkSeaGreen",
			"DarkSlateBlue",
			"DarkSlateGray",
			"DarkTurquoise",
			"DarkViolet"
		};

		public CATIA_3D ()
		{
			InitializeComponent ();

			Random random = new Random();
			int randomNumber = random.Next(0, TileColorList.Count);


			users.Add(new User() { Name = "Ub", VersionNo = "5.2.3", TileColor = TileColorList[randomNumber]});
			users.Add(new User() { Name = "Ct", VersionNo = "5.1.2", TileColor = TileColorList[randomNumber]});
			users.Add(new User() { Name = "Be", VersionNo = "5.4.2", TileColor = TileColorList[randomNumber]});
			users.Add(new User() { Name = "Ub", VersionNo = "5.2.3", TileColor = TileColorList[randomNumber]});
			users.Add(new User() { Name = "Ct", VersionNo = "5.1.2", TileColor = TileColorList[randomNumber]});
			users.Add(new User() { Name = "Be", VersionNo = "5.4.2", TileColor = TileColorList[randomNumber]});
			users.Add(new User() { Name = "Ub", VersionNo = "5.2.3", TileColor = TileColorList[randomNumber]});
			users.Add(new User() { Name = "Ct", VersionNo = "5.1.2", TileColor = TileColorList[randomNumber]});
			users.Add(new User() { Name = "Be", VersionNo = "5.4.2", TileColor = TileColorList[randomNumber]});
			users.Add(new User() { Name = "Ub", VersionNo = "5.2.3", TileColor = TileColorList[randomNumber]});
			users.Add(new User() { Name = "Ct", VersionNo = "5.1.2", TileColor = TileColorList[randomNumber]});
			users.Add(new User() { Name = "Be", VersionNo = "5.4.2", TileColor = TileColorList[randomNumber]});

			MyListview3D.ItemsSource = users;
		}

		public class User 
		{

			private string tilecolor;
			public string TileColor
			{
				get { return this.tilecolor; }
				set
				{
					if (this.tilecolor != value)
					{
						this.tilecolor = value;
						//this.NotifyPropertyChanged("TileColor");
					}
				}
			}


			private string versionNo;
			public string VersionNo
			{
				get { return this.versionNo; }
				set
				{
					if (this.versionNo != value)
					{
						this.versionNo = value;
						//this.NotifyPropertyChanged("VersionNo");
					}
				}
			}


			private string name;
			public string Name
			{
				get { return this.name; }
				set
				{
					if (this.name != value)
					{
						this.name = value;
						//this.NotifyPropertyChanged("Name");
					}
				}
			}


		}


	}


}

