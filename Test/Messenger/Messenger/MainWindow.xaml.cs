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
using System.Data;
using System.Data.SqlClient;
//using System.Windows.Forms;
namespace Messenger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            cl_DB.DB DB = new cl_DB.DB();

           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Btn_Send_Click(object sender, RoutedEventArgs e)
        {
            //SqlConnection sqlConnection1 = new SqlConnection("Server=TCP:cn6weywxh7.database.windows.net,1433;Database=Messenger;User ID=candymanis@cn6weywxh7;Password=Vanilla1;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "INSERT INTO Message (Sender, Recipient, MessageString,) VALUES ('Jason', 'Ron', 'Hello')";
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //reader = cmd.ExecuteReader();
            //// Data is accessible through the DataReader object here.

            //sqlConnection1.Close();

           SqlConnection sqlConnection1 = new SqlConnection("Server=TCP:cn6weywxh7.database.windows.net,1433;Database=Messenger;User ID=candymanis@cn6weywxh7;Password=Vanilla1;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");

         SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT  Message (Sender, Receiver, MessageString) VALUES ('"+ Tbx_LoggeInUser .Text+ "', '"+ Tbx_Receiver .Text+ "', '" + Tbx_Message.Text + "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();



            MessageBox.Show("done");

        }
    }
}
