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
            listBoxSelRecIng.DisplayMember = "Name";
            //instruction
            richTextBoxForInstruction.Text = recipe.Instruction;
		}

        private void butSearchRecipe_Click(object sender, EventArgs e)
        {
            List<Recipe> SearchRecipe = SearchData.SearchRecipeByName(textBoxSearchRecipe.Text);
            listBoxAllRecipes.DataSource = SearchRecipe;
            listBoxAllRecipes.DisplayMember = "Name";
            listBoxAllRecipes.ValueMember = "Id";
        }

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            string nameRecipe = addNameRecipeTextBox.Text;
            string instructionRecipe = addInstrRecipeTextBox.Text;
            DataAdding.AddRecipe(nameRecipe, instructionRecipe);
            addInstrRecipeTextBox.Text = "";
            addNameRecipeTextBox.Text = "";
            allRecipes = DataAccess.GetAllRecipes();
            listBoxAllRecipes.DataSource = allRecipes;
        }
    }
}


