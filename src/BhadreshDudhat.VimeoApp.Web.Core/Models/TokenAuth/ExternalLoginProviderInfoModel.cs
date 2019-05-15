using Abp.AutoMapper;
using BhadreshDudhat.VimeoApp.Authentication.External;

namespace BhadreshDudhat.VimeoApp.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
