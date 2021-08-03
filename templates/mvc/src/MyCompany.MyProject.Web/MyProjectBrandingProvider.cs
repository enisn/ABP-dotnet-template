﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MyCompany.MyProject.Web
{
    [Dependency(ReplaceServices = true)]
    public class MyProjectBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MyProject";
    }
}
