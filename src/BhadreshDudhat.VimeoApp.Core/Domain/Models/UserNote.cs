using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BhadreshDudhat.VimeoApp.Domain.Models
{
    public class UserNote : Entity
    {
        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string Notes { get; set; }
    }
}

//ABP's base Entity class, which includes Id property as int by default.