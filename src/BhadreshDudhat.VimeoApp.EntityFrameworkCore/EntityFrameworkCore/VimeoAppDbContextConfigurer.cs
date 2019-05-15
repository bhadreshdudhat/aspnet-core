using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BhadreshDudhat.VimeoApp.EntityFrameworkCore
{
    public static class VimeoAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VimeoAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VimeoAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
