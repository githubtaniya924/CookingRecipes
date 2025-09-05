using Microsoft.EntityFrameworkCore;
using CookingRecipes.Models;

namespace CookingRecipes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Step> Steps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ Seed Recipes
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    Id = 1,
                    Title = "Veg Biryani",
                    ImageUrl = "https://i.ytimg.com/vi/Do7ZdUodDdw/maxresdefault.jpg",
                    Description = "A flavorful rice dish with spices and mixed vegetables.",
                    Cuisine = "Indian",
                    Rating = 4.5,
                    Servings = 4,
                    Tips = "Serve hot with raita for best taste."
                },
                new Recipe
                {
                    Id = 2,
                    Title = "Pasta Alfredo",
                    ImageUrl = "https://images.aws.nestle.recipes/resized/0a0717810b73a1672a029c29788e557b_creamy_alfredo_pasta_long_left_1200_628.jpg",
                    Description = "Creamy Alfredo pasta with parmesan cheese.",
                    Cuisine = "Italian",
                    Rating = 4.2,
                    Servings = 2,
                    Tips = "Add garlic bread for extra flavor."
                }
            );

            // ✅ Seed Ingredients
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, RecipeId = 1, Name = "Basmati Rice", Quantity = 250, Unit = "grams" },
                new Ingredient { Id = 2, RecipeId = 1, Name = "Mixed Vegetables", Quantity = 200, Unit = "grams" },
                new Ingredient { Id = 3, RecipeId = 1, Name = "Biryani Masala", Quantity = 2, Unit = "tbsp" },

                new Ingredient { Id = 4, RecipeId = 2, Name = "Pasta", Quantity = 200, Unit = "grams" },
                new Ingredient { Id = 5, RecipeId = 2, Name = "Cream", Quantity = 100, Unit = "ml" },
                new Ingredient { Id = 6, RecipeId = 2, Name = "Parmesan Cheese", Quantity = 50, Unit = "grams" }
            );

            // ✅ Seed Steps
            modelBuilder.Entity<Step>().HasData(
                new Step { Id = 1, RecipeId = 1, StepNumber = 1, Instruction = "Wash and soak rice for 30 mins." },
                new Step { Id = 2, RecipeId = 1, StepNumber = 2, Instruction = "Cook vegetables with spices." },
                new Step { Id = 3, RecipeId = 1, StepNumber = 3, Instruction = "Layer rice and veggies, cook on dum." },

                new Step { Id = 4, RecipeId = 2, StepNumber = 1, Instruction = "Boil pasta until al dente." },
                new Step { Id = 5, RecipeId = 2, StepNumber = 2, Instruction = "Prepare Alfredo sauce with cream and cheese." },
                new Step { Id = 6, RecipeId = 2, StepNumber = 3, Instruction = "Mix pasta with sauce and serve hot." }
            );
        }
    }
}
