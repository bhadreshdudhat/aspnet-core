using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using BhadreshDudhat.VimeoApp.Authorization;
using BhadreshDudhat.VimeoApp.Authorization.Roles;
using BhadreshDudhat.VimeoApp.Authorization.Users;
using BhadreshDudhat.VimeoApp.Editions;
using BhadreshDudhat.VimeoApp.MultiTenancy;

namespace BhadreshDudhat.VimeoApp.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
