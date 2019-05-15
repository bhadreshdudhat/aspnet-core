using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BhadreshDudhat.VimeoApp.Authorization.Roles;
using BhadreshDudhat.VimeoApp.Authorization.Users;
using BhadreshDudhat.VimeoApp.MultiTenancy;

namespace BhadreshDudhat.VimeoApp.EntityFrameworkCore
{
    public class VimeoAppDbContext : AbpZeroDbContext<Tenant, Role, User, VimeoAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public VimeoAppDbContext(DbContextOptions<VimeoAppDbContext> options)
            : base(options)
        {
        }
    }
}
