using Notedown.Core.Services;
using Notedown.Infrastructure.Services;
using Notedown.Web.ViewModels;

namespace Notedown.Web.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddNotes(this IServiceCollection services)
    {
        services
            .AddSingleton<IFileService, FileService>()
            .AddSingleton<INoteService, FileNoteService>();

        return services;
    }

    public static IServiceCollection AddViewModels(this IServiceCollection services)
    {
        services.AddSingleton<AddViewModel>();

        return services;
    }
}
