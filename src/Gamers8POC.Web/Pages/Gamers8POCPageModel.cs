using Gamers8POC.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Gamers8POC.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class Gamers8POCPageModel : AbpPageModel
{
    protected Gamers8POCPageModel()
    {
        LocalizationResourceType = typeof(Gamers8POCResource);
    }
}
