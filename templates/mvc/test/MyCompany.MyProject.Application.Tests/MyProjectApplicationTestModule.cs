using Volo.Abp.Modularity;

namespace MyCompany.MyProject
{
    [DependsOn(
        typeof(MyProjectApplicationModule),
        typeof(MyProjectDomainTestModule)
        )]
    public class MyProjectApplicationTestModule : AbpModule
    {

    }
}