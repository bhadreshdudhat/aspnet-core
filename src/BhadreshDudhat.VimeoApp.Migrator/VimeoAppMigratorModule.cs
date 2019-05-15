using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BhadreshDudhat.VimeoApp.Configuration;
using BhadreshDudhat.VimeoApp.EntityFrameworkCore;
using BhadreshDudhat.VimeoApp.Migrator.DependencyInjection;

namespace BhadreshDudhat.VimeoApp.Migrator
{
    [DependsOn(typeof(VimeoAppEntityFrameworkModule))]
    public class VimeoAppMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public VimeoAppMigratorModule(VimeoAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(VimeoAppMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                VimeoAppConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VimeoAppMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
