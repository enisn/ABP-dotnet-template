using MyCompany.MyProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyCompany.MyProject
{
    [DependsOn(
        typeof(MyProjectEntityFrameworkCoreTestModule)
        )]
    public class MyProjectDomainTestModule : AbpModule
    {

    }
}