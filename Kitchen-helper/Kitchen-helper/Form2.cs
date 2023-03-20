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
            textBox1.Text += usedIngredients;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
