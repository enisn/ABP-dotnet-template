using MyCompany.MyProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MyCompany.MyProject.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MyProjectPageModel : AbpPageModel
    {
        protected MyProjectPageModel()
        {
            LocalizationResourceType = typeof(MyProjectResource);
        }
    }
}