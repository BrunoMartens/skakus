using Microsoft.EntityFrameworkCore;
using skakus.data.Entities;
using skakus.data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skakus.data.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly SkakusDbContext context;

        public GameRepository(SkakusDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Game>> GetAll()
        {
            return await context.Games.ToListAsync();
        }
    }
}
