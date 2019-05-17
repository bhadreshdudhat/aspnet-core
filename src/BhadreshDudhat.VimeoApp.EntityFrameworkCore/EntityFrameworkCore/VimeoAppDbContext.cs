using Abp.Zero.EntityFrameworkCore;
using BhadreshDudhat.VimeoApp.Authorization.Roles;
using BhadreshDudhat.VimeoApp.Authorization.Users;
using BhadreshDudhat.VimeoApp.Domain.Models;
using BhadreshDudhat.VimeoApp.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace BhadreshDudhat.VimeoApp.EntityFrameworkCore
{
    public class VimeoAppDbContext : AbpZeroDbContext<Tenant, Role, User, VimeoAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<UserNote> UserNotes { get; set; }

        public VimeoAppDbContext(DbContextOptions<VimeoAppDbContext> options)
            : base(options)
        {
        }
    }
}
