using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace DataProcess;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DataProcessHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class DataProcessConsoleApiClientModule : AbpModule
{

}
