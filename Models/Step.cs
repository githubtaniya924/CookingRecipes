using System.ComponentModel.DataAnnotations;

namespace CookingRecipes.Models
{
    public class Step
    {
        public int Id { get; set; }

        [Required]
        public int RecipeId { get; set; }

        [Required]
        public int StepNumber { get; set; }

        [Required]
        public string Instruction { get; set; }

        // Navigation property
        public Recipe Recipe { get; set; }
    }
}
