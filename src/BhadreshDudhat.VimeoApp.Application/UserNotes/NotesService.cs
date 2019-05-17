using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using BhadreshDudhat.VimeoApp.Domain.Models;
using BhadreshDudhat.VimeoApp.UserNotes.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BhadreshDudhat.VimeoApp.UserNotes
{
    public class NotesService : VimeoAppAppServiceBase, INotesService
    {
        private readonly IRepository<UserNote> _usernoteRepository;

        public NotesService(IRepository<UserNote> usernoteRepository)
        {
            _usernoteRepository = usernoteRepository;
        }

        public async Task<ListResultDto<UserNoteDto>> GetAll(string useremail)
        {
            var notes = await _usernoteRepository
                 .GetAll()
                 //.Where(n => n.UserEmail == useremail)
                 .ToListAsync();

            return new ListResultDto<UserNoteDto>(
                ObjectMapper.Map<List<UserNoteDto>>(notes)
            );//mapping UserNote List to UserNoteDto List and creating & returning ListResultDto<UserNoteDto>
        }

        public async Task<ListResultDto<string>> GetAllNotes(string useremail)
        {
            var notes = await _usernoteRepository
                 .GetAll()
                 .Where(n => n.UserEmail == useremail)
                 .Select(n => n.Notes)
                 .ToListAsync();

            return new ListResultDto<string>(notes);
        }

        public async Task CreateNote(UserNoteDto noteDto)
        {
            var note = ObjectMapper.Map<UserNote>(noteDto);
            await _usernoteRepository.InsertAsync(note);
        }

        public void UpdateNote(int id, UserNoteDto noteDto)
        {
            var note = _usernoteRepository.Get(id);
            note.Notes = noteDto.Notes;

        }

        public async void DeleteNote(int id)
        {
            await _usernoteRepository.DeleteAsync(id);

        }
    }
}
// ApplicationService base class has some pre-injected services (like ObjectMapper used here).

//Repositories are used to abstract database operations for entities. ABP creates a pre-defined repository (like IRepository<T> ) for each entity to perform common tasks. IRepository.GetAll() used here returns an IQueryable to query entities.

//When an application service is automatically converted to an MVC Controller, it's default route will look like this: /api/services/<module-name>/<service-name>/<method-name>. For example, if ProductAppService defines a Create method, it's URL will be /api/services/app/product/create (assuming that the module name is 'app').