using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BhadreshDudhat.VimeoApp.MultiTenancy.Dto;

namespace BhadreshDudhat.VimeoApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

