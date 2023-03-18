using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SQLite;

namespace Kitchen_helper
{
    internal class DataBase
    {
        private SQLiteConnection connection;
        public DataBase()
        {
            connection = new SQLiteConnection("Data Source=Recipes_book");
            if(File.Exists("./Recipes_book"))
            {
                Debug.WriteLine("TEST");
            }
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
        public SQLiteConnection getConnection()
        {
            return connection;
        }

    }
}
