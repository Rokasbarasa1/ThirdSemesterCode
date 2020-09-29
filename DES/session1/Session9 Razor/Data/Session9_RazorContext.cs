using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session9_Razor.Model;

namespace Session9_Razor.Data
{
    public class Session9_RazorContext : DbContext
    {
        public Session9_RazorContext (DbContextOptions<Session9_RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Session9_Razor.Model.Movie> Movie { get; set; }
    }
}
