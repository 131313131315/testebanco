

using Db.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Db.CrossCutting.DependencyInjection
{
    public static class ConfigureConexaoDB
    {
        public static IServiceCollection ConfigureConexaoRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
