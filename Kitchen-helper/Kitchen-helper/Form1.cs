using System.Diagnostics;
using System.Data.SQLite;
using System.Xml.Linq;
using System.Windows.Forms;

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
            List<String> usedIngredients = new List<string>();
            foreach (object itemChecked in ingredientsList.CheckedItems)
            {
                usedIngredients.Add(itemChecked.ToString());
            }
            Form2 form2 = new Form2(usedIngredients);
            form2.ShowDialog();
            this.Hide();

        }
    }
}