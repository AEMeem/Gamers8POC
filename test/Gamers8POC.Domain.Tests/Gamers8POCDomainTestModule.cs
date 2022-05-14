using Gamers8POC.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Gamers8POC;

[DependsOn(
    typeof(Gamers8POCEntityFrameworkCoreTestModule)
    )]
public class Gamers8POCDomainTestModule : AbpModule
{

}
