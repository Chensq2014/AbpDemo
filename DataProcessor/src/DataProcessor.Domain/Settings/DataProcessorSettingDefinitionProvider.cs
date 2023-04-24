using Volo.Abp.Settings;

namespace DataProcessor.Settings;

public class DataProcessorSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DataProcessorSettings.MySetting1));
    }
}
