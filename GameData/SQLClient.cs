using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BUNKER.GameData
{
     public class SQLClient
    {
        static public bool connected = false;
        static protected string connetionString = null;
        static protected string request = "";

        static SqlConnection cnn;
        static SqlDataReader reader;
        static SQLClient()
        {
            connetionString = "Data Source= (LocalDB)\\MSSQLLocalDB;Initial Catalog=BunkerDB;Integrated Security=True";
        }
        static public void Connect()
        {
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                connected = true;

            }
            catch (Exception ex)
            {
            }
        }
        static public void Disconnect()
        {
            cnn.Close();
        }
        static protected void InitSqlRequest()
        {
            SqlCommand sqlRequest = new SqlCommand(request, cnn);
            reader = sqlRequest.ExecuteReader();
        }
        static protected List<string> GetResults()
        {
            List<string> results = new List<string>();
            while(reader.Read())
            {
                results.Add(reader.GetString(0));
            }
            return results;
        }
    }
}