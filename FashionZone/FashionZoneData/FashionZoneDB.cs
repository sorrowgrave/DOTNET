using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class FashionZoneDB
    {
        OleDbConnection connection;
        DataTable dt;

        public FashionZoneDB()
        {
            GetConnection();
        }

        public OleDbConnection GetConnection()
        {
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/FashionZone.accdb";
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);


            string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + location + ";Persist Security Info=False;";
            connection = new OleDbConnection(ConnStr);
            return connection;
        }

        public DataTable selectTable(string statement)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            OleDbCommand command = new OleDbCommand(statement, connection);
            OleDbDataAdapter da = new OleDbDataAdapter(command);

            dt = new DataTable();
            da.Fill(dt);

            connection.Close();

            return dt;
        }

        public async void updateTable(string statement)
        {
            OleDbCommand cmd = new OleDbCommand();

            if (connection.State != ConnectionState.Open)
                connection.Open();

            cmd.Connection = connection;
            cmd.CommandText = statement;
            await cmd.ExecuteNonQueryAsync();

            connection.Close();

        }
    }
}
