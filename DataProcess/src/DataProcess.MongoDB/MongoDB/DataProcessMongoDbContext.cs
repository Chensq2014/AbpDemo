using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace DataProcess.MongoDB;

[ConnectionStringName(DataProcessDbProperties.ConnectionStringName)]
public class DataProcessMongoDbContext : AbpMongoDbContext, IDataProcessMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureDataProcess();
    }
}
