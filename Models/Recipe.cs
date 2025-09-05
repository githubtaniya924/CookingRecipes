using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CookingRecipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }

        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Cuisine { get; set; }

        [Range(0, 5)]
        public double Rating { get; set; }

        public int Servings { get; set; }
        public string Tips { get; set; }

        // Navigation properties
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Step> Steps { get; set; }
    }
}
