using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DTT.CMS.ContentManager;

[Dependency(ReplaceServices = true)]
public class ContentManagerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ContentManager";
}
