using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using BhadreshDudhat.VimeoApp.Authorization.Roles;
using BhadreshDudhat.VimeoApp.Authorization.Users;
using BhadreshDudhat.VimeoApp.MultiTenancy;

namespace BhadreshDudhat.VimeoApp.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options, 
            SignInManager signInManager,
            ISystemClock systemClock) 
            : base(
                  options, 
                  signInManager, 
                  systemClock)
        {
        }
    }
}
