using Notedown.Core.Entities;
using Notedown.Core.Services;

namespace Notedown.Infrastructure.Services;

public sealed class FileNoteService : INoteService
{
    private readonly IFileService fileService;

    public FileNoteService(IFileService fileService)
    {
        this.fileService = fileService;
    }

    public Task AddNoteAsync(Note note, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Note>> GetAllNotesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Note> GetNoteAsync(string title, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task EditNteAsync(Note note, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task RemoveNoteAsync(string title, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
