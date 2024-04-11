using Volo.Abp.Settings;

namespace DTT.CMS.ContentManager.Settings;

public class ContentManagerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ContentManagerSettings.MySetting1));
    }
}
