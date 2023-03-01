using Microsoft.EntityFrameworkCore;

namespace RecipeAPI.Models
{
    public class DishesDBContext: DbContext
    {
        public DishesDBContext(DbContextOptions<DishesDBContext> options) : base(options) 
        {
        
        }

        public DbSet<Dish> Dishes { get; set; }
    }
}
