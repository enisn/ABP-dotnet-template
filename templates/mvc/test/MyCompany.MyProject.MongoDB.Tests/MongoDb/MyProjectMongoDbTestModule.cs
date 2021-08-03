using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace MyCompany.MyProject.MongoDB
{
    [DependsOn(
        typeof(MyProjectTestBaseModule),
        typeof(MyProjectMongoDbModule)
        )]
    public class MyProjectMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var stringArray = MyProjectMongoDbFixture.ConnectionString.Split('?');
                        var connectionString = stringArray[0].EnsureEndsWith('/')  +
                                                   "Db_" +
                                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}
