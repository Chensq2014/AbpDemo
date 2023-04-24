using DataProcessor.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DataProcessor.Web.Pages;

public abstract class DataProcessorPageModel : AbpPageModel
{
    protected DataProcessorPageModel()
    {
        LocalizationResourceType = typeof(DataProcessorResource);
    }
}
