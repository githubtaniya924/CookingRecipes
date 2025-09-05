using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using CookingRecipes.Data;
using CookingRecipes.Models;

namespace CookingRecipes.Pages
{
    public class RecipeFinderModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public RecipeFinderModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipes { get; set; }

        public async Task OnGetAsync()
        {
            Recipes = await _context.Recipes.ToListAsync();
        }
    }
}
