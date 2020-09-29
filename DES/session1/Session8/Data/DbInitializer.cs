using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session8.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Cats.Any())
            {
                return;
            }

            var cats = new Cat[]
            {
                new Cat{id = 2, name = "Candy", color = "Red", price = 154.15, birthdate = 05/29/2015, favoriteDish = "Cooked dog"}
            };

            foreach (Cat cat in cats)
            {
                context.Add(p);
            }
            context.SaveChanges();
        }
    }
}
