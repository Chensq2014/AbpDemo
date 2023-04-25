namespace DataProcess;

public static class DataProcessDbProperties
{
    public static string DbTablePrefix { get; set; } = "DataProcess";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "DataProcess";
}
