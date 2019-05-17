using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BhadreshDudhat.VimeoApp.UserNotes.Dto;
using System.Threading.Tasks;

namespace BhadreshDudhat.VimeoApp.UserNotes
{
    public interface INotesService : IApplicationService
    {

        Task<ListResultDto<UserNoteDto>> GetAll(string useremail);
        Task<ListResultDto<string>> GetAllNotes(string useremail);

        Task CreateNote(UserNoteDto note);

        void UpdateNote(int id, UserNoteDto note);
        void DeleteNote(int id);

    }
}
