using System;
using System.Collections.Generic;
using System.Text;
using DTT.CMS.ContentManager.Localization;
using Volo.Abp.Application.Services;

namespace DTT.CMS.ContentManager;

/* Inherit your application services from this class.
 */
public abstract class ContentManagerAppService : ApplicationService
{
    protected ContentManagerAppService()
    {
        LocalizationResource = typeof(ContentManagerResource);
    }
}
