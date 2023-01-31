using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace RecipeFoodBook
{
    public static class DataManipulate
    {
        public static void AddRecipe(string name, string instruction)
        {
            using (DbConnection connection = new SqlConnection(DBConnector.ConnectionValue()))
            {
                connection.Execute($"Insert into Recipes (Name, Instruction) values('{name}', '{instruction}')");
            }
        }

        public static void RemoveRecipe(string selectedId)
        {
            using (DbConnection connection = new SqlConnection(DBConnector.ConnectionValue()))
            {
                connection.Execute($"Delete from RecipeIngredient where RecipeId = {selectedId}");
                connection.Execute($"Delete from Recipes where Id = {selectedId}");
            }
        }

        public static void AddNewIngredient(string name)
        {
            using (DbConnection connection = new SqlConnection(DBConnector.ConnectionValue()))
            {
                connection.Execute($"Insert into Ingredients (Name) values('{name}')");
            }
        }

        public static void DeleteIngredient(string selectedId)
        {
            using (DbConnection connection = new SqlConnection(DBConnector.ConnectionValue()))
            {
                connection.Execute($"Delete from RecipeIngredient where IngredientId = {selectedId}");
                connection.Execute($"Delete from Ingredients where Id = {selectedId}");
            }
        }

        public static void AddIngredientToRecipe (string ingredientSelId , string recipeSelId)
        {
            using(DbConnection connection = new SqlConnection(DBConnector.ConnectionValue())) 
            {
                connection.Execute($"Insert into RecipeIngredient (RecipeId, IngredientId) values('{recipeSelId}', '{ingredientSelId}')");
            }
        }

        public static void UpdateRecipeInstruction(string instruction, string selectedId)
        {
            using(DbConnection connection = new SqlConnection(DBConnector.ConnectionValue()))
            {
                connection.Execute($"Update Recipes Set Instruction = '{instruction}' Where Id = {selectedId}");
            }
        }


        public static void UpdateRecipeName (string title, string selectedId)
        {
            using(DbConnection connection = new SqlConnection(DBConnector.ConnectionValue()))
            {
                connection.Execute($"Update Recipes Set Name = '{title}' Where Id = {selectedId}");
            }
        }

        public static void UpdateIngredientName(string title, string selectedId)
        {
            using (DbConnection connection = new SqlConnection(DBConnector.ConnectionValue()))
            {
                connection.Execute($"Update Ingredients Set Name = '{title}' Where Id = {selectedId}");
            }
        }

        public static void RemoveIngredientFromRecipe(string selectedRecipeId, string selectedIngrId)
        {
            using(DbConnection connection = new SqlConnection(DBConnector.ConnectionValue()))
            {
                connection.Execute($"Delete from RecipeIngredient Where RecipeId = {selectedRecipeId} And IngredientId = {selectedIngrId}");
            }
        }
    }
}
