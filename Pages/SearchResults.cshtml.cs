using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CookingRecipes.Data;
using CookingRecipes.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CookingRecipes.Pages
{
    public class SearchResultsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public SearchResultsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string Query { get; set; }

        public IList<Recipe> Results { get; set; }

        public async Task OnGetAsync()
        {
            if (string.IsNullOrWhiteSpace(Query))
            {
                Results = new List<Recipe>();
                return;
            }

            Results = await _context.Recipes
                .Where(r => r.Title.Contains(Query) || r.Cuisine.Contains(Query))
                .ToListAsync();
        }
    }
}
