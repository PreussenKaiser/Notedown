using Notedown.Core.Entities;

namespace Notedown.Core.Services;

public interface INoteService
{
    Task AddNoteAsync(Note note, CancellationToken cancellationToken = default);

    Task<IEnumerable<Note>> GetAllNotesAsync(CancellationToken cancellationToken = default);

    Task<Note> GetNoteAsync(string title, CancellationToken cancellationToken = default);

    Task EditNteAsync(Note note, CancellationToken cancellationToken = default);

    Task RemoveNoteAsync(string title, CancellationToken cancellationToken = default);
}
