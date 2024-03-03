using Microsoft.Extensions.DependencyInjection;
using skakus.data.Repositories.Interfaces;
using skakus.data.Repositories;
using skakus.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using skakus.domain.Services;
using skakus.domain.Services.Interfaces;

namespace skakus.domain.Configuration
{
    public static class ServicesConfiguration
    {
        public static void AddSkakusDomain(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(SkakusDomainProfile));
            services.AddTransient<IGameService, GameService>();
        }
    }
}
