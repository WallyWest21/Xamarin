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
using System.Windows.Shapes;

namespace HeadsUpXAML
{
    /// <summary>
    /// Interaction logic for SubCategory.xaml
    /// </summary>
    public partial class SubCategory : Window
    {
        public SubCategory()
        {
            InitializeComponent();
        }

        private void label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DBOperations DB = new DBOperations();
             DB.ConnectToAccessDB();
            MessageBoxResult result = MessageBox.Show("Do you want to close this window?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }
}
