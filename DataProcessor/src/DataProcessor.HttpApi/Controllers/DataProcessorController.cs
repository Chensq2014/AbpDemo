using DataProcessor.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DataProcessor.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DataProcessorController : AbpControllerBase
{
    protected DataProcessorController()
    {
        LocalizationResource = typeof(DataProcessorResource);
    }
}
