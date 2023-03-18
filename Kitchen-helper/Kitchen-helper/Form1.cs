using System.Diagnostics;
using System.Data.SQLite;

namespace Kitchen_helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillIngredientChecklist();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillIngredientChecklist()
        {
            DataBase dataBase = new DataBase();
            SQLiteCommand command = new SQLiteCommand("SELECT Name FROM Ingredient", dataBase.getConnection());
            SQLiteDataReader reader;
            dataBase.openConnention();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ingredientsList.Items.Add(reader["Name"]);
                }

            }
            dataBase.closeConnention();
        }

    }
}