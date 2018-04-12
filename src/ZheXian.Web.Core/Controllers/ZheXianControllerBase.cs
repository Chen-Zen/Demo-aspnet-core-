using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ZheXian.Controllers
{
    public abstract class ZheXianControllerBase: AbpController
    {
        protected ZheXianControllerBase()
        {
            LocalizationSourceName = ZheXianConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
