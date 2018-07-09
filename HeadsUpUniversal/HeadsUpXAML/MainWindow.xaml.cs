using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HeadsUpXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Label Category = new Label();
            //Category.Content = "TV /Movie";
            //MainGrid.Children.Add(Category);
            //Category.SetValue(Grid.RowProperty, 2);
            //Category.SetValue(Grid.ColumnProperty, 1);

            //string categoryname;

            var salmons = new List<string> { "TV Shows", "Movies", "Actors", "Marvel", "Animals", "DC", "One Piece", "DBZ", "Bleach"  };

            for (int index = 0; index < salmons.Count; index++)
            {

                decimal RowNo, ColumnNo;
                    int Rows, Columns;
                Columns = 4;


                string LabelName = salmons[index];
               
                Label CategoryName = new Label();
                CategoryName.Content = LabelName;
                CategoryName.HorizontalContentAlignment = HorizontalAlignment.Center;
                CategoryName.VerticalContentAlignment = VerticalAlignment.Center;
                CategoryName.Background = Brushes.DarkSlateBlue;
                CategoryName.Foreground = Brushes.White;
                CategoryName.FontSize = 42;
                CategoryName.MouseDown += CategoryName_MouseDown;


                MainGrid.Children.Add(CategoryName);

                if (index == 0)
                {
                    ColumnNo = 3 % index;
                    RowNo = 0;
                }
                else
                {
                    ColumnNo = 3 % index;
                    RowNo = ( index/ Columns);
                    RowNo = Math.Floor(RowNo);
                }
                CategoryName.SetValue(Grid.RowProperty, RowNo);
                CategoryName.SetValue(Grid.ColumnProperty, ColumnNo);
            }

        }

        private void CategoryName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBoxResult result = MessageBox.Show("Do you want to close this window?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            SubCategory subc = new SubCategory ();
            subc.Show();
        }

      
    }
}
