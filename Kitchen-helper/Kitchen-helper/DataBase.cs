using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SQLite;
using System.Data.Entity;

namespace Kitchen_helper
{
    internal class DataBase
    {
        private SQLiteConnection connection;
        public DataBase()
        {
            connection = new SQLiteConnection("Data Source=Recipes_book");
        }
        public void openConnention()
        {
            if(connection.State != System.Data.ConnectionState.Open)
            connection.Open();
        }
        public void closeConnention()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Close();
        }

        public SQLiteDataReader readFromDatabase(string column, string table)
        {
            SQLiteDataReader reader;
            SQLiteCommand command = new SQLiteCommand("SELECT " + column + " FROM " + table, connection);
            reader = command.ExecuteReader();
            return reader;

        }

    }
}
