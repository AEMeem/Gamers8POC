using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Gamers8POC.Web;

[Dependency(ReplaceServices = true)]
public class Gamers8POCBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Gamers8POC";
}
