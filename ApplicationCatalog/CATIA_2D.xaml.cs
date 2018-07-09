using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace ApplicationCatalog
{
	public partial class CATIA_2D : ContentPage
	{
		public static int ScreenWidth;
		public static int ScreenHeight;

		private ObservableCollection<User> users = new ObservableCollection<User>();
		public ObservableCollection<string> TileColorList = new ObservableCollection<string>
		{   "Aqua",
			"Black",
			"Blue",
			"Fuchsia",
			"Gray",
			"Green",
			"Lime",
			"Maroon",
			"Navy",
			"Olive",
			"Purple",
			"Pink",
			"Red",
			"Silver",
			"Teal",
			"White",
			"Yellow"
		};
		public CATIA_2D ()
		{
			InitializeComponent ();

			users.Add(new User() { Name = "Ub", VersionNo = "5.2.3", TileColor = TileColorList[0]});
			users.Add(new User() { Name = "Ct", VersionNo = "5.1.2", TileColor = TileColorList[1]});
			users.Add(new User() { Name = "Be", VersionNo = "5.4.2", TileColor = TileColorList[2]});
			users.Add(new User() { Name = "Ub", VersionNo = "5.2.3", TileColor = TileColorList[3]});
			users.Add(new User() { Name = "Ct", VersionNo = "5.1.2", TileColor = TileColorList[4]});
			users.Add(new User() { Name = "Be", VersionNo = "5.4.2", TileColor = TileColorList[5]});
			users.Add(new User() { Name = "Ub", VersionNo = "5.2.3", TileColor = TileColorList[6]});
			users.Add(new User() { Name = "Ct", VersionNo = "5.1.2", TileColor = TileColorList[7]});
			users.Add(new User() { Name = "Be", VersionNo = "5.4.2", TileColor = TileColorList[8]});
			users.Add(new User() { Name = "Ub", VersionNo = "5.2.3", TileColor = TileColorList[9]});
			users.Add(new User() { Name = "Ct", VersionNo = "5.1.2", TileColor = TileColorList[10]});
			users.Add(new User() { Name = "Be", VersionNo = "5.4.2", TileColor = TileColorList[11]});

			Grid grid = new Grid
			{
				BackgroundColor=Color.White,
				VerticalOptions = LayoutOptions.Fill,
				HorizontalOptions= LayoutOptions.CenterAndExpand,
				RowDefinitions =
				{
					new RowDefinition { },
					new RowDefinition { },
					new RowDefinition { },
					new RowDefinition { }
				},
				ColumnDefinitions =
				{//					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
				}
				};

			grid.RowDefinitions [0].Height = grid.ColumnDefinitions [0].Width;
			grid.RowDefinitions [1].Height = grid.ColumnDefinitions [0].Width;
			grid.RowDefinitions [2].Height = grid.ColumnDefinitions [0].Width;
			grid.RowDefinitions [3].Height = grid.ColumnDefinitions [0].Width;
//			grid.Children.Add(new Label
//				{
//					Text = "Grid",
//					FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
//					HorizontalOptions = LayoutOptions.Center
//				}, 0, 3, 0, 1);

//			grid.Children.Add(new Label
//				{
//
//										Text = "Autosized cell",
//					TextColor = Color.White,
//					FontSize=Device.GetNamedSize(NamedSize.Small, typeof(Label)),
//					HorizontalTextAlignment = TextAlignment.Center,
//					VerticalTextAlignment = TextAlignment.Center,
//					BackgroundColor = Color.Blue
//				}, 0, 0);
			grid.Children.Add(new StackLayout
			{
					BackgroundColor=Color.Navy,
				Spacing = 0,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = 
				{
						new Label
						{
							TextColor=Color.White,
							FontSize=Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
							FontFamily ="Segoe UI Light",
							HorizontalOptions = LayoutOptions.End,
							VerticalOptions=LayoutOptions.CenterAndExpand,
							Text = "5.2.3"
						},

					new Label
						{
							TextColor=Color.White,
//							BackgroundColor=Color.Red,
							FontSize=80,
							FontFamily ="Segoe UI Semibold",
							HorizontalOptions = LayoutOptions.Start,
							VerticalOptions=LayoutOptions.EndAndExpand,
							Text = "Be"
						},
								new Label
												{		
							TextColor=Color.White,
//							BackgroundColor=Color.Blue,
								FontSize=Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
								FontFamily ="Segoe UI Light",
								HorizontalOptions = LayoutOptions.Start,
							VerticalOptions=LayoutOptions.EndAndExpand,
							Text = "BOM Export"

							},
													
						new Label
						{
							TextColor=Color.White,
							FontSize=Device.GetNamedSize(NamedSize.Small, typeof(Label)),
							FontFamily ="Segoe UI Light",
							HorizontalOptions = LayoutOptions.Start,
							VerticalOptions=LayoutOptions.StartAndExpand,
							Text = "This will export the 3D and 2D from CATIA"

						},

				}
			},0,0);
				
			grid.Children.Add(new BoxView
				{
					Color = Color.Silver,
					HeightRequest = 0
				}, 1, 1);

			grid.Children.Add(new BoxView
				{
					Color = Color.Teal
				}, 2, 0);

			grid.Children.Add(new Label
				{
					Text = "Leftover space",
					TextColor = Color.Black,
					FontSize=Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
					BackgroundColor = Color.Aqua,
					HorizontalTextAlignment = TextAlignment.Center,
					VerticalTextAlignment = TextAlignment.Center,

				}, 1, 0);

			grid.Children.Add(new Label
				{
					Text = "Span two rows (or more if you want)",
					TextColor = Color.Yellow,
					FontSize=Device.GetNamedSize(NamedSize.Large, typeof(Label)),
					BackgroundColor = Color.Navy,
					HorizontalTextAlignment = TextAlignment.Center,
					VerticalTextAlignment = TextAlignment.Center
				}, 1, 2);

			grid.Children.Add(new Label
				{
					Text = "Span 2 columns",
					TextColor = Color.Blue,
					BackgroundColor = Color.Yellow,
					FontSize=Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
					HorizontalTextAlignment = TextAlignment.Center,
					VerticalTextAlignment = TextAlignment.Center
				}, 0, 2, 3, 4);

			grid.Children.Add(new Label
				{
					Text = ScreenWidth.ToString(),
					TextColor = Color.Aqua,
					BackgroundColor = Color.Red,
					HorizontalTextAlignment = TextAlignment.Center,
					VerticalTextAlignment = TextAlignment.Center
				}, 0, 2);

			this.Padding = new Thickness(20, Device.OnPlatform(20, 0, 0), 10, 5);

			// Build the page.
			this.Content = grid;
		}
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

