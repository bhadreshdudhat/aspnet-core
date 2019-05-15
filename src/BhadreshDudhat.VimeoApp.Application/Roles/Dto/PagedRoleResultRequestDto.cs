using Abp.Application.Services.Dto;

namespace BhadreshDudhat.VimeoApp.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

