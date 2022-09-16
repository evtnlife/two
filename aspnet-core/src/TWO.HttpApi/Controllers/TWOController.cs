using TWO.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TWO.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TWOController : AbpControllerBase
{
    protected TWOController()
    {
        LocalizationResource = typeof(TWOResource);
    }
}
