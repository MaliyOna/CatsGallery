using CatsGallery.Abstractions;
using CatsGallery.Services;
using CatsGallery.ViewModels;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Mopups.Hosting;

namespace CatsGallery
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureMopups()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<ICatsService, CatsService>();
            builder.Services.AddSingleton<CatsViewModel>();
            builder.Services.AddSingleton<IPopupService, Services.PopupService>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
