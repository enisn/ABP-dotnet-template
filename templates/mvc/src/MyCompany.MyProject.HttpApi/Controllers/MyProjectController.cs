using MyCompany.MyProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyCompany.MyProject.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MyProjectController : AbpController
    {
        protected MyProjectController()
        {
            LocalizationResource = typeof(MyProjectResource);
        }
    }
}