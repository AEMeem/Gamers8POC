using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Gamers8POC.Data;

/* This is used if database provider does't define
 * IGamers8POCDbSchemaMigrator implementation.
 */
public class NullGamers8POCDbSchemaMigrator : IGamers8POCDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
