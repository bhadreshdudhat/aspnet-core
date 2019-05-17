using Abp.AutoMapper;
using BhadreshDudhat.VimeoApp.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace BhadreshDudhat.VimeoApp.UserNotes.Dto
{
    [AutoMapFrom(typeof(UserNote))]
    [AutoMapTo(typeof(UserNote))]
    public class UserNoteDto
    {
        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string Notes { get; set; }
    }
}
