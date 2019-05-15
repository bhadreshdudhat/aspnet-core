using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BhadreshDudhat.VimeoApp.Roles.Dto;
using BhadreshDudhat.VimeoApp.Users.Dto;

namespace BhadreshDudhat.VimeoApp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
