using Volo.Abp.Settings;

namespace TWO.Settings;

public class TWOSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TWOSettings.MySetting1));
    }
}
