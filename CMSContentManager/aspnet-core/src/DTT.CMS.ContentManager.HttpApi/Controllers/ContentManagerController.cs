using DTT.CMS.ContentManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DTT.CMS.ContentManager.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ContentManagerController : AbpControllerBase
{
    protected ContentManagerController()
    {
        LocalizationResource = typeof(ContentManagerResource);
    }
}
