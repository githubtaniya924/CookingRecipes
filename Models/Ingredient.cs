using System.ComponentModel.DataAnnotations;

namespace CookingRecipes.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        public int RecipeId { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        [Range(1, 9999)]
        public int Quantity { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        // Navigation property
        public Recipe Recipe { get; set; }
    }
}
