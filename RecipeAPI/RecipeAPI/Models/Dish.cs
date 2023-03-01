using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeAPI.Models
{
    public class Dish
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string dishName { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string category { get; set;}

        
        public int complexity { get; set; }


        public int time { get; set; }


        public int efficiency { get; set; }

        
    }
}
