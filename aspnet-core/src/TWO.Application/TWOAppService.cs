using System;
using System.Collections.Generic;
using System.Text;
using TWO.Localization;
using Volo.Abp.Application.Services;

namespace TWO;

/* Inherit your application services from this class.
 */
public abstract class TWOAppService : ApplicationService
{
    protected TWOAppService()
    {
        LocalizationResource = typeof(TWOResource);
    }
}
