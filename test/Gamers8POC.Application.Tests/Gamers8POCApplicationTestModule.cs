using Volo.Abp.Modularity;

namespace Gamers8POC;

[DependsOn(
    typeof(Gamers8POCApplicationModule),
    typeof(Gamers8POCDomainTestModule)
    )]
public class Gamers8POCApplicationTestModule : AbpModule
{

}
