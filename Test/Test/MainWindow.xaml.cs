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
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();


        public MainWindow()
        {
            InitializeComponent();

            users.Add(new User() { Name = "John Doe" });

            users.Add(new User() { Name = "Jane Doe" });

            users.Add(new User() { Name = "JD" });





            //lbUsers.ItemsSource = users;

            MyListBox.ItemsSource = users;

        }



        public class User : INotifyPropertyChanged

        {

            private string name;

            public string Name

            {

                get { return this.name; }

                set

                {

                    if (this.name != value)

                    {

                        this.name = value;

                        this.NotifyPropertyChanged("Name");

                    }

                }

            }



            public event PropertyChangedEventHandler PropertyChanged;



            public void NotifyPropertyChanged(string propName)

            {

                if (this.PropertyChanged != null)

                    this.PropertyChanged(this, new PropertyChangedEventArgs(propName));

            }

        }

    }

}
