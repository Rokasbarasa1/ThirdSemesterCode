using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Session9_Razor.Data;
using Session9_Razor.Model;

namespace Session9_Razor.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly Session9_Razor.Data.Session9_RazorContext _context;

        public DetailsModel(Session9_Razor.Data.Session9_RazorContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
