using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace DataProcess.MongoDB;

[ConnectionStringName(DataProcessDbProperties.ConnectionStringName)]
public interface IDataProcessMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
