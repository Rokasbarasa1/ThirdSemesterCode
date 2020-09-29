using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Contexts
{
    public class TodoContextDatabase : DbContext
    {
        public TodoContextDatabase(DbContextOptions<TodoContextDatabase> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
