using Abp.MultiTenancy;
using BhadreshDudhat.VimeoApp.Authorization.Users;

namespace BhadreshDudhat.VimeoApp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
