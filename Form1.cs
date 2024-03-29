﻿using System;
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
            listBoxAllIngredients.DataSource = chosenIngredients;
            listBoxAllIngredients.DisplayMember = "Name";
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
            UpdateRecipes();
        }


        private void showAllIngredientsButton_Click(object sender, EventArgs e)
        {
            UpdateIngredients();
        }

        private void deleteIngredientButton_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = (Ingredient)listBoxAllIngredients.SelectedItem;
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
            UpdateIngredients();
        }

        private void addIngredientToRecipeButton_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = listBoxAllIngredients.SelectedItem as Ingredient;
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
            UpdateRecipes();
        }

        private void changeRecipeNameButton_Click(object sender, EventArgs e)
        {
            Recipe recipe = (Recipe)listBoxAllRecipes.SelectedItem;
            string selectedId = "";
            string newRecipeTitle = changeRecipeNameTextBox.Text;
            if (recipe != null)
            {
                selectedId = recipe.Id.ToString();
            }
            DataManipulate.UpdateRecipeName(newRecipeTitle, selectedId);
            UpdateRecipes();
            changeRecipeNameTextBox.Text = "";
        }

        private void changeIngredientNameButton_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = (Ingredient)listBoxAllIngredients.SelectedItem;
            string selectedId = "";
            string newIngredientTitle = changeIngredientNameTextBox.Text;
            if (ingredient != null)
            {
                selectedId = ingredient.Id.ToString();
            }
            DataManipulate.UpdateIngredientName(newIngredientTitle, selectedId);
            UpdateIngredients();
            changeIngredientNameTextBox.Text = "";
        }

        private void removeFromRecopeButton_Click(object sender, EventArgs e)
        {
            Recipe recipe = (Recipe)listBoxAllRecipes.SelectedItem;
            Ingredient ingredient = (Ingredient)listBoxAllIngredients.SelectedItem;
            string ingredientId = "";
            string recipeId = "";
            if (ingredient != null && recipe != null)
            {
                ingredientId = ingredient.Id.ToString();
                recipeId = recipe.Id.ToString();
            }
            DataManipulate.RemoveIngredientFromRecipe(recipeId, ingredientId);
            List<Ingredient> chosenIngredients = DataAccess.GetIngredientsFromSelectedRecipe(recipeId);
            listBoxAllIngredients.DataSource = chosenIngredients;
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            AddingRecipeForm addRecipe = new AddingRecipeForm();
            addRecipe.FormClosing += new FormClosingEventHandler(this.AddingRecipeForm_FormClosing);
            addRecipe.Show();
        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            AddIngredientForm addIngredient = new AddIngredientForm();
            addIngredient.FormClosing += new FormClosingEventHandler(this.AddIngredientForm_FormClosing);
            addIngredient.Show();
        }

        private void AddingRecipeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateRecipes();
        }

        private void AddIngredientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateIngredients();
        }

        private void UpdateRecipes()
        {
            allRecipes = DataAccess.GetAllRecipes();
            listBoxAllRecipes.DataSource = allRecipes;
        }

        private void UpdateIngredients()
        {
            allIngredients = DataAccess.GetAllIngredients();
            listBoxAllIngredients.DataSource = allIngredients;
            listBoxAllIngredients.DisplayMember = "Name";
        }

        private void ShowAllRecipesButton_Click(object sender, EventArgs e)
        {
            UpdateRecipes();
        }

        private void searchIngredientButton_Click(object sender, EventArgs e)
        {
            string name = searchIngredientsTextBox.Text;
            if(name == "All" || name == "ALL" || name == "all")
            {
                UpdateIngredients();
            }
            else
            {
                List<Ingredient> ingredients = SearchData.SearchIngredientByName(name);
                listBoxAllIngredients.DataSource = ingredients;
            }
        }
    }
}


