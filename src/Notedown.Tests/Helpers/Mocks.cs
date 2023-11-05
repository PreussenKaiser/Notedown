using Moq;
using Notedown.Core.Services;

namespace Notedown.Tests.Helpers;

internal static class Mocks
{
    internal static Mock<IFileService> FileService()
    {
        var fileService = new Mock<IFileService>();

        return fileService;
    }

    internal static Mock<INoteService> NoteService()
    {
        var noteService = new Mock<INoteService>();

        return noteService;
    }
}
