using DataProcess.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DataProcess;

public abstract class DataProcessController : AbpControllerBase
{
    protected DataProcessController()
    {
        LocalizationResource = typeof(DataProcessResource);
    }
}
