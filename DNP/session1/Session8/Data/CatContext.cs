using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session8.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Session8.Data
{
    public class CatContext : DbContext
    {
        public CatContext(DbContextOptions<CatContext> options) : base(options)
        {
        }
        public DbSet<Cat> cats { get; set; }
        public DbSet<Order> orders { get; set; }
    }
}
