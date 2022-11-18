using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;


namespace RecipeFoodBook
{
    public partial class RecipeBook : Form
    {
        //Get all recipes from Book
        List<Recipe> allRecipes = DataAccess.GetAllRecipes();
        
        public RecipeBook()
        {
            InitializeComponent();
        }
        private void RecipeBook_Load(object sender, EventArgs e)
        {
            //Connect list box with list of all recipes 
            listBoxAllRecipes.DataSource = allRecipes;
            listBoxAllRecipes.DisplayMember = "Name";
            listBoxAllRecipes.ValueMember = "Id";
        }
        private void listBoxAllRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recipe recipe = listBoxAllRecipes.SelectedItem as Recipe;
            string value = "";
            if (listBoxAllRecipes.SelectedItem != null)
            {
                value = Convert.ToString(recipe.Id);
            }
            List<Ingredient> chosenIngredients = DataAccess.GetIngredientsFromSelectedRecipe(value);
            listBoxSelRecIng.DataSource = chosenIngredients;
            listBoxSelRecIng.DisplayMember = "ShortInfo";

            richTextBoxForInstruction.Text = recipe.Instruction;
        }

        
    }
}


