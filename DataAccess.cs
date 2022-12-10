using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace RecipeFoodBook
{
    public static class DataAccess
    {
        public static List<Recipe> GetAllRecipes()
        {
            using (IDbConnection connection = new SqlConnection(DBConnector.ConnectionValue()))
            {
                var output = connection.Query<Recipe>("Select * from Recipes").ToList();
                return output;
            }
        }
        
        public static List<Ingredient> GetIngredientsFromSelectedRecipe(string selectedId)
        {
            using (IDbConnection connection = new SqlConnection(DBConnector.ConnectionValue()))
            {
                if (!string.IsNullOrEmpty(selectedId))
                {
                    var output = connection.Query<Ingredient>($@"Select Ingredients.* from Ingredients
                                                             Join RecipeIngredient
                                                             on Ingredients.Id = RecipeIngredient.IngredientId
                                                             Where RecipeIngredient.RecipeId = {selectedId}").ToList();

                    return output;
                }
                return new List<Ingredient>();
            }
        }
        
    }
}
