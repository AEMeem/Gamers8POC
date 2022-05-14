using System;
using System.Collections.Generic;
using System.Text;
using Gamers8POC.Localization;
using Volo.Abp.Application.Services;

namespace Gamers8POC;

/* Inherit your application services from this class.
 */
public abstract class Gamers8POCAppService : ApplicationService
{
    protected Gamers8POCAppService()
    {
        LocalizationResource = typeof(Gamers8POCResource);
    }
}
