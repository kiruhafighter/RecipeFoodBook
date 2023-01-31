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
    public partial class AddingRecipeForm : Form
    {
        public AddingRecipeForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string recipeName = textBoxName.Text;
            string recipeInstruction = textBoxInstruction.Text;
            DataManipulate.AddRecipe(recipeName, recipeInstruction);
            textBoxName.Text = "";
            textBoxInstruction.Text = "";
            Close();
        }
    }
}
