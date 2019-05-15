using System.ComponentModel.DataAnnotations;

namespace BhadreshDudhat.VimeoApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}