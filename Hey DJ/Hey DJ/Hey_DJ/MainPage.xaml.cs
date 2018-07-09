using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using System.IO;

namespace Hey_DJ
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "HeyDJ.db3");
            //var db = new SQLiteConnection(dbPath);


        }


        void AddNewMessage(object sender, EventArgs e)
        {
            Button NewMessage = new Button
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,             
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BackgroundColor = Color.White,
				TextColor = Color.Black,
                Text=entry_NewMessage.Text      
            };

            NewMessage.Clicked += ShowMessage;
            sl_MainLayout.Children.Add(NewMessage);
            entry_NewMessage.Text = null;
        }


        void ShowMessage(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            App.Message = btn.Text;
            Navigation.PushAsync(new MessagePage());
        }
    }

    [Table("Items")]
    public class Stock
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [MaxLength(8)]
        public string Symbol { get; set; }
    }


}
