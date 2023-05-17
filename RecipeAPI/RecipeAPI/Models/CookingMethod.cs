using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeAPI.Models
{
    public class CookingMethod
    {
    
        public int id { get; set; }
        
        public string name { get; set; } = string.Empty;

        public List<Dish> Dishes { get; set; }

        
    }
}