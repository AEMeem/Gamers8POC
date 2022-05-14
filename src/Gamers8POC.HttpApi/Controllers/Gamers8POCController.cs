using Gamers8POC.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Gamers8POC.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Gamers8POCController : AbpControllerBase
{
    protected Gamers8POCController()
    {
        LocalizationResource = typeof(Gamers8POCResource);
    }
}
