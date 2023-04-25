using Volo.Abp;
using Volo.Abp.MongoDB;

namespace DataProcess.MongoDB;

public static class DataProcessMongoDbContextExtensions
{
    public static void ConfigureDataProcess(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
