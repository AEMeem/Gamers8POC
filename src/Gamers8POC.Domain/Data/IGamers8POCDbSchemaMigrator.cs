using System.Threading.Tasks;

namespace Gamers8POC.Data;

public interface IGamers8POCDbSchemaMigrator
{
    Task MigrateAsync();
}
