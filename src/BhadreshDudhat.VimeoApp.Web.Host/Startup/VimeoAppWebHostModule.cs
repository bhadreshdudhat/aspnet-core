using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BhadreshDudhat.VimeoApp.Configuration;

namespace BhadreshDudhat.VimeoApp.Web.Host.Startup
{
    [DependsOn(
       typeof(VimeoAppWebCoreModule))]
    public class VimeoAppWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VimeoAppWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VimeoAppWebHostModule).GetAssembly());
        }
    }
}
