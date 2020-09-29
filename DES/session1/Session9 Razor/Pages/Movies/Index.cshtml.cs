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
    public class IndexModel : PageModel
    {
        private readonly Session9_Razor.Data.Session9_RazorContext _context;

        public IndexModel(Session9_Razor.Data.Session9_RazorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
