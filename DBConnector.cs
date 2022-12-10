using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace RecipeFoodBook
{
    public class DBConnector
    {
        public static string ConnectionValue ()
        {
            return ConfigurationManager.ConnectionStrings["RecipesDB"].ConnectionString;
        }
    }
}
