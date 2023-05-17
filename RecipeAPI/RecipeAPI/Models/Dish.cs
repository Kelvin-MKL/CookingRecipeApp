using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeAPI.Models
{
    public class Dish
    {
        
        public int id { get; set; }

        public string dishName { get; set; }


        public string category { get; set;}

        
        public int complexity { get; set; }


        public int time { get; set; }


        public int efficiency { get; set; }

        public CookingMethod CookingMethod { get; set; }
        public int cookingMethodId { get; set; }
        

        
    }
}
