using Microsoft.EntityFrameworkCore;
using skakus.data.Entities;

namespace skakus.data
{
    public class SkakusDbContext: DbContext
    {
        public SkakusDbContext(DbContextOptions<SkakusDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}
