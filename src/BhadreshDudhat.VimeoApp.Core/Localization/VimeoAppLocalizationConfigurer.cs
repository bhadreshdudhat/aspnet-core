using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace BhadreshDudhat.VimeoApp.Localization
{
    public static class VimeoAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(VimeoAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(VimeoAppLocalizationConfigurer).GetAssembly(),
                        "BhadreshDudhat.VimeoApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
