using Notedown.Core.Services;
using Notedown.Web.Models;

namespace Notedown.Web.ViewModels;

public sealed class AddViewModel : ViewModelBase
{
    private readonly INoteService noteService;

    public AddViewModel(INoteService noteService)
    {
        this.noteService = noteService;

        this.Note = new NoteModel();
    }

    public NoteModel Note { get; set; }

    public void AddNote()
    {
    }
}
