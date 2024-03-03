using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using skakus.data.Repositories;
using skakus.data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skakus.data.Configuration
{
    public static class ServicesConfiguration
    {
        public static void AddSkakusData(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SkakusDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddTransient<IGameRepository, GameRepository>();
        }
    }
}
