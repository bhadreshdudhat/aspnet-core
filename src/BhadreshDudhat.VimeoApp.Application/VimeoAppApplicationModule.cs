using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BhadreshDudhat.VimeoApp.Authorization;

namespace BhadreshDudhat.VimeoApp
{
    [DependsOn(
        typeof(VimeoAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VimeoAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VimeoAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VimeoAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
