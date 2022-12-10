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
        List<Ingredient> allIngredients = new List<Ingredient>();
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
            DataManipulate.AddRecipe(nameRecipe, instructionRecipe);
            addInstrRecipeTextBox.Text = "";
            addNameRecipeTextBox.Text = "";
            allRecipes = DataAccess.GetAllRecipes();
            listBoxAllRecipes.DataSource = allRecipes;
        }

        private void deleteRecipeButton_Click(object sender, EventArgs e)
        {
            Recipe recipe = (Recipe)listBoxAllRecipes.SelectedItem;
            string value = "";
            if (recipe != null)
            {
                value = Convert.ToString(recipe.Id);
            }
            DialogResult dgDelete = MessageBox.Show("Delete Recipe from DataBase?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning , MessageBoxDefaultButton.Button1);
            if(dgDelete == DialogResult.OK)
            {
                DataManipulate.RemoveRecipe(value);
            }
            allRecipes = DataAccess.GetAllRecipes();
            listBoxAllRecipes.DataSource = allRecipes;
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            string nameIngredient = addIngredientTextBox.Text;
            DataManipulate.AddNewIngredient(nameIngredient);
            addIngredientTextBox.Text = "";
            allRecipes = DataAccess.GetAllRecipes();
            listBoxAllRecipes.DataSource = allRecipes;
        }

        private void showAllIngredientsButton_Click(object sender, EventArgs e)
        {
            allIngredients = DataAccess.GetAllIngredients();
            listBoxSelRecIng.DataSource = allIngredients;
            listBoxSelRecIng.DisplayMember = "Name";
        }

        private void deleteIngredientButton_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = (Ingredient)listBoxSelRecIng.SelectedItem;
            string value = "";
            if (ingredient != null)
            {
                value = ingredient.Id.ToString();
            }
            DialogResult dgDelete = MessageBox.Show("Delete Ingredient from DataBase?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dgDelete == DialogResult.OK)
            {
                DataManipulate.DeleteIngredient(value);
            }
            allIngredients = DataAccess.GetAllIngredients();
            listBoxSelRecIng.DataSource = allIngredients;
        }

        private void addIngredientToRecipeButton_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = listBoxSelRecIng.SelectedItem as Ingredient;
            Recipe recipe = listBoxAllRecipes.SelectedItem as Recipe;
            string ingredientId = "";
            string recipeId = "";
            if(ingredient != null && recipe != null)
            {
                ingredientId = ingredient.Id.ToString();
                recipeId = recipe.Id.ToString();
            }
            DataManipulate.AddIngredientToRecipe(ingredientId, recipeId);
        }

        private void updateInstructionButton_Click(object sender, EventArgs e)
        {
            Recipe recipe = (Recipe)listBoxAllRecipes.SelectedItem;
            string selectedId = "";
            string newInstruction = richTextBoxForInstruction.Text;
            if (recipe != null)
            {
                selectedId = recipe.Id.ToString();
            }
            DataManipulate.UpdateRecipeInstruction(newInstruction, selectedId);
            allRecipes = DataAccess.GetAllRecipes();
            listBoxAllRecipes.DataSource = allRecipes;
        }
    }
}


