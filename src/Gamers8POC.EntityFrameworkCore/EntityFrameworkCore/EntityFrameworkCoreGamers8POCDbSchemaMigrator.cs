using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Gamers8POC.Data;
using Volo.Abp.DependencyInjection;

namespace Gamers8POC.EntityFrameworkCore;

public class EntityFrameworkCoreGamers8POCDbSchemaMigrator
    : IGamers8POCDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreGamers8POCDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Gamers8POCDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Gamers8POCDbContext>()
            .Database
            .MigrateAsync();
    }
}
