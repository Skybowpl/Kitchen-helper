using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kitchen_helper
{
    public partial class Form2 : Form
    {
        private List<object> uniqueRecipesIdList = new List<object>();
        public Form2(List<String> usedIngredients)
        {
            InitializeComponent();
            DataBase dataBase = new DataBase();
            dataBase.openConnention();

            foreach (object itemChecked in usedIngredients)
            {
                SQLiteDataReader ingredientIdReader = dataBase.readFromDatabase("ID", "Ingredient", "name = " + "\"" + itemChecked.ToString() + "\"");
                SQLiteDataReader recipestIdReader;

                if (ingredientIdReader.HasRows)
                {
                    while (ingredientIdReader.Read())
                    {
                        recipestIdReader = dataBase.readFromDatabase("Recipe_id", "Recipe_details", "Ingredient_id = " + "\"" + ingredientIdReader["ID"] + "\"");

                        if (recipestIdReader.HasRows)
                        {
                            while (recipestIdReader.Read())
                            {
                                if (!uniqueRecipesIdList.Contains(recipestIdReader["Recipe_id"]))
                                {
                                    uniqueRecipesIdList.Add(recipestIdReader["Recipe_id"]);
                                }
                            }
                        }
                    }
                }

            }
            foreach (object recipe_id in uniqueRecipesIdList)
            {
                SQLiteDataReader recipeReader;
                recipeReader = dataBase.readFromDatabase("Name", "Recipe", "ID = " + "\"" + recipe_id.ToString() + "\"");
                if (recipeReader.HasRows)
                {
                    while (recipeReader.Read())
                    {
                        richTextBox1.Text += recipeReader["Name"];
                        richTextBox1.Text += "\n";

                    }
                }

                recipeReader = dataBase.readFromDatabase("Ingredient_id, Ammount", "Recipe_details", "Recipe_id = " + "\"" + recipe_id.ToString() + "\"");
                if (recipeReader.HasRows)
                {
                    while (recipeReader.Read())
                    {
                        SQLiteDataReader ingredientReader = dataBase.readFromDatabase("Name", "Ingredient", "ID = " + "\"" + recipeReader["Ingredient_id"] + "\"");
                        if (ingredientReader.HasRows)
                        {
                            while (ingredientReader.Read())
                            {
                                richTextBox1.Text += ingredientReader["Name"];
                            }
                        }
                        richTextBox1.Text += " ";
                        richTextBox1.Text += recipeReader["Ammount"];
                        richTextBox1.Text += "\n";
                    }
                }


                recipeReader = dataBase.readFromDatabase("Recipe_text", "Recipe", "id = " + "\"" + recipe_id.ToString() + "\"");
                if (recipeReader.HasRows)
                {
                    while (recipeReader.Read())
                    {
                        richTextBox1.Text += recipeReader["Recipe_text"];
                        richTextBox1.Text += "\n";
                        richTextBox1.Text += "/////////////////////////////////////////////////////////////////////////////////////////////////////////";
                        richTextBox1.Text += "\n";
                    }
                }
            }
            dataBase.closeConnention();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
