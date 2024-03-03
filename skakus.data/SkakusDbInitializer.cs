using skakus.data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skakus.data
{
    public static class SkakusDbInitializer
    {
        public static void Initialize(SkakusDbContext context)
        {
            // Look for any students.
            if (context.Games.Any())
            {
                return;   // DB has been seeded
            }

            var games = new Game[]
            {
                new("Alfa"),
                new("Beta")
            };

            context.Games.AddRange(games);
            context.SaveChanges();  
        }
    }
}
