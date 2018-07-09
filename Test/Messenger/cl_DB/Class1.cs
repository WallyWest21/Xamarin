using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;



namespace cl_DB
{
    public class DB
    {
       

        
        //public   AddMessage()
        //{
        //    List<object> AddMsg = new List<object>(); 

        //    OleDbConnection connection = new OleDbConnection();
        //    OleDbCommand command = new OleDbCommand();
        //    OleDbDataAdapter adpater = new OleDbDataAdapter();
        //    DataSet dataset = new DataSet();

        //    connection.ConnectionString = @"Provider=MIcrosoft.ACE.OLEDB.12.0;Data Source= Messenger.mbd;" +
        //        "Persist Security Info=False";
        //    command.Connection = connection;
        //    command.CommandText = "SELECT * FROM Message";
        //    adpater.SelectCommand = command;

        //   try
        //    {
        //        adpater.Fill(dataset, "AddMessage");
        //        MessageBox.Show("Connected!");

        //    }
        //    catch (OleDbException)
        //    {
        //        MessageBox.Show("Error");
        //    }



        //   AddMsg=dataset.Tables["AddMessage"].DefaultView;
        //}

        //public var RetrieveMessages()
        //{
        //    return 0;
        //}

    }
}
