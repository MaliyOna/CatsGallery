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
                    handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(1);
                    handler.PlatformView.BorderBrush = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Gray);
                    handler.PlatformView.CornerRadius = new Microsoft.UI.Xaml.CornerRadius(5);
                    handler.PlatformView.Background = null;

                    var margin = new Microsoft.UI.Xaml.Thickness(5, 0, 5, 10);
                    handler.PlatformView.Margin = margin;

                    handler.PlatformView.GotFocus += (sender, args) =>
                    {
                        handler.PlatformView.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.LightGray);
                    };

                    handler.PlatformView.LostFocus += (sender, args) =>
                    {
                        handler.PlatformView.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.White);
                    };
#endif
                }
            });
        }
    }
}
