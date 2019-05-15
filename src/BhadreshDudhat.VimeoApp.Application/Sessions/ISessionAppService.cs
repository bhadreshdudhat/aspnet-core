using System.Threading.Tasks;
using Abp.Application.Services;
using BhadreshDudhat.VimeoApp.Sessions.Dto;

namespace BhadreshDudhat.VimeoApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
