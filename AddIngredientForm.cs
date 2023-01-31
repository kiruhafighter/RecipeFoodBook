using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeFoodBook
{
    public partial class AddIngredientForm : Form
    {
        public AddIngredientForm()
        {
            InitializeComponent();
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            string nameIngredient = addIngredientTextBox.Text;
            DataManipulate.AddNewIngredient(nameIngredient);
            Close();
        }
    }
}
