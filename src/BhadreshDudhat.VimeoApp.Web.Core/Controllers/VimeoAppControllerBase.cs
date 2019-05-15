using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BhadreshDudhat.VimeoApp.Controllers
{
    public abstract class VimeoAppControllerBase: AbpController
    {
        protected VimeoAppControllerBase()
        {
            LocalizationSourceName = VimeoAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
