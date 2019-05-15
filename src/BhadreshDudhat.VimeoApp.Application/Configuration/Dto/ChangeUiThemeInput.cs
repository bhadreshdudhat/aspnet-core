using System.ComponentModel.DataAnnotations;

namespace BhadreshDudhat.VimeoApp.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
