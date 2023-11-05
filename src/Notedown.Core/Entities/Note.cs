namespace Notedown.Core.Entities;

public sealed class Note
{
    /// <summary>
    /// Also used as the filename.
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// A string containing markdown.
    /// </summary>
    public required string Content { get; init; }
}
