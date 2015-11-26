using System.Data;
using System.Data.Entity;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using System.Configuration;

public class MyDbConfiguration : DbConfiguration
{
    public MyDbConfiguration()
    {
        // Register ADO.NET provider
        var dataSet = (DataSet)ConfigurationManager.GetSection("system.data");
        dataSet.Tables[0].Rows.Add(
            "MySQL Data Provider",
            ".Net Framework Data Provider for MySQL",
            "MySql.Data.MySqlClient",
            typeof(MySqlClientFactory).AssemblyQualifiedName
        );

        // Register Entity Framework provider
        SetProviderServices("MySql.Data.MySqlClient", new MySqlProviderServices());
        SetDefaultConnectionFactory(new MySqlConnectionFactory());
    }
}