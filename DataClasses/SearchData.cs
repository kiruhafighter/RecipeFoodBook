using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Web.UI.WebControls;

namespace RecipeFoodBook
{
    public static class SearchData
    {
        public static List<Recipe> SearchRecipeByName(string name)
        {
            using (IDbConnection conn = new SqlConnection(DBConnector.ConnectionValue()))
            {
                List<Recipe> output;
                
                if (name == "all" || name == "All" || name == "All")
                {
                    output = conn.Query<Recipe>("Select * from Recipes").ToList();
                    return output;
                }
                else
                {
                    output = conn.Query<Recipe>($"Select * from Recipes where Name = '{name}'").ToList();
                    return output;
                }

            }
        }
    }
}
