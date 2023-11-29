using Api.Domain.Interfaces;
using Db.Data.Repositories;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
namespace Db.CrossCutting.DependencyInjection
{
    public class ConfigureServiceDB
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            serviceCollection.AddScoped(typeof(IUnitOfWorkGenerico<>), typeof(UnitOfWorkGenerico<>));

            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped(typeof(IRepositoryGenerico<>), typeof(BaseRepositoryGenerico<>));
        }
    }
}
