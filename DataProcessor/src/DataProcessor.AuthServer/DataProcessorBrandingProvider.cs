using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace DataProcessor;

[Dependency(ReplaceServices = true)]
public class DataProcessorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DataProcessor";
}
