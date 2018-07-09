using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Xml.Serialization;

namespace HeadsUpXAML
{
    class DBOperations
    {
       public  void ConnectToAccessDB () //(string ServerName, string DBName)
        {
            //https://msdn.microsoft.com/en-us/library/aa288452(v=vs.71).aspx

            string strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Headsup.accdb";
            string strAccessSelect = "SELECT * FROM Main Category";

            DataSet myDataSet = new DataSet();
            OleDbConnection myAccessConn = null;
            try
            {
                myAccessConn = new OleDbConnection(strAccessConn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to create a database connection. \n{0}", ex.Message);
                return;
            }

            try

            {

                OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

                myAccessConn.Open();
                myDataAdapter.Fill(myDataSet, "Main Category");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
                return;
            }
            finally
            {
                myAccessConn.Close();
            }
        }
        public static List<string> GetTableof(string TableName)
        {
            var TableList = new List<string>();
            return TableList;
        }
    }
}
