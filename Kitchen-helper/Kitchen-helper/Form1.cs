using System.Diagnostics;
using System.Data.SQLite;
using System.Xml.Linq;

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
            dataBase.openConnention();
            SQLiteDataReader reader = dataBase.readFromDatabase("Name", "Ingredient");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ingredientsList.Items.Add(reader["Name"]);
                }

            }
            dataBase.closeConnention();
        }

        private void goNextButton_Click(object sender, EventArgs e)
        {

        }
    }
}