using Gamers8POC.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Gamers8POC.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Gamers8POCEntityFrameworkCoreModule),
    typeof(Gamers8POCApplicationContractsModule)
    )]
public class Gamers8POCDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
