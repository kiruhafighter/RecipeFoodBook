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
    public static class DataAdding
    {
        public static void AddRecipe(string name, string instruction)
        {
            using (DbConnection connection = new SqlConnection(DBConnector.ConnectionValue()))
            {
                connection.Execute($"Insert into Recipes (Name, Instruction) values('{name}', '{instruction}')");
            }
        }
    }
}
