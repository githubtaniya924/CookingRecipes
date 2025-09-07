using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CookingRecipes.Data;
using CookingRecipes.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingRecipes.Pages
{
    public class RecipeFinderModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public RecipeFinderModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Recipe> RandomRecipes { get; set; }

        public async Task OnGetAsync()
        {
            // Get 3 random recipes for suggestions
            RandomRecipes = await _context.Recipes
                .OrderBy(r => EF.Functions.Random())
                .Take(3)
                .ToListAsync();
        }
    }
}
