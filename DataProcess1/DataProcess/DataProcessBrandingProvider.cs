using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DataProcess;

[Dependency(ReplaceServices = true)]
public class DataProcessBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DataProcess";
}
