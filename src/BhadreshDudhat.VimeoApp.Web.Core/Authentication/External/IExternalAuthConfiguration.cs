using System.Collections.Generic;

namespace BhadreshDudhat.VimeoApp.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
