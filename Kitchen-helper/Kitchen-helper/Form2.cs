using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_helper
{
    public partial class Form2 : Form
    {
        public Form2(List<String> usedIngredients)
        {
            InitializeComponent();
            foreach (object itemChecked in usedIngredients)
            {
                richTextBox1.Text += itemChecked.ToString();
                richTextBox1.Text += "\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
