using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasPumpWebService.Model
{
    public class GasPumpContext : DbContext
    {
        public GasPumpContext(DbContextOptions<GasPumpContext> options) : base(options)
        {
        }

        public DbSet<Refil> Refils { get; set; }
        public DbSet<CapacityLowering> CapacityLowerings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Refil>()
                .Property(e => e.id)
                .IsRequired();
            modelBuilder.Entity<CapacityLowering>()
                .Property(e => e.id)
                .IsRequired();
        }
    }
}
