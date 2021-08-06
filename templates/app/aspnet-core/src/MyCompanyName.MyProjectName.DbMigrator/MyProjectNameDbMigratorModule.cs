#if EfCore
using MyCompanyName.MyProjectName.EntityFrameworkCore;
#endif
#if MongoDb
using MyCompanyName.MyProjectName.MongoDB;
#endif
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MyCompanyName.MyProjectName.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        #if EfCore
        typeof(MyProjectNameEntityFrameworkCoreModule),
        #endif 
        #if MongoDb
        typeof(MyProjectNameMongoDbModule),
        #endif 
        typeof(MyProjectNameApplicationContractsModule)
        )]
    public class MyProjectNameDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
