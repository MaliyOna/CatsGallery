using Microsoft.Maui.Platform;

namespace CatsGallery.Handlers
{
    public static class Handlers
    {
        public static void RegisterHandlers()
        {
            ConfigureEntry();
        }

        private static void ConfigureEntry()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
                if (view is Entry)
                {
#if __ANDROID__
                    handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
                    handler.PlatformView.Background = null;
#elif WINDOWS
                    handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
                    handler.PlatformView.BorderBrush = null;
                    handler.PlatformView.Background = null;
#endif
                }
            });
        }
    }
}
