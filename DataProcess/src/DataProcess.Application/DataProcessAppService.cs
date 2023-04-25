using DataProcess.Localization;
using Volo.Abp.Application.Services;

namespace DataProcess;

public abstract class DataProcessAppService : ApplicationService
{
    protected DataProcessAppService()
    {
        LocalizationResource = typeof(DataProcessResource);
        ObjectMapperContext = typeof(DataProcessApplicationModule);
    }
}
