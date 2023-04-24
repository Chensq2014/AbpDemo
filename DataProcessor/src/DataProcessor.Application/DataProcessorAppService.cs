using System;
using System.Collections.Generic;
using System.Text;
using DataProcessor.Localization;
using Volo.Abp.Application.Services;

namespace DataProcessor;

/* Inherit your application services from this class.
 */
public abstract class DataProcessorAppService : ApplicationService
{
    protected DataProcessorAppService()
    {
        LocalizationResource = typeof(DataProcessorResource);
    }
}
