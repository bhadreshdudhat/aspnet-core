using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BhadreshDudhat.VimeoApp.Configuration;
using BhadreshDudhat.VimeoApp.Web;

namespace BhadreshDudhat.VimeoApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class VimeoAppDbContextFactory : IDesignTimeDbContextFactory<VimeoAppDbContext>
    {
        public VimeoAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VimeoAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            VimeoAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(VimeoAppConsts.ConnectionStringName));

            return new VimeoAppDbContext(builder.Options);
        }
    }
}
