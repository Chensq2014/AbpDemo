using Localization.Resources.AbpUi;
using DataProcess.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace DataProcess;

[DependsOn(
    typeof(DataProcessApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class DataProcessHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(DataProcessHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<DataProcessResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
