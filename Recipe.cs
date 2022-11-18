using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeFoodBook
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instruction { get; set; } 
        public string ShortInfo
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
