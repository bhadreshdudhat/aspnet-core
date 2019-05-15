using System.Threading.Tasks;
using BhadreshDudhat.VimeoApp.Configuration.Dto;

namespace BhadreshDudhat.VimeoApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
