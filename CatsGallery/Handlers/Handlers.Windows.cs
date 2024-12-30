#if WINDOWS
using Microsoft.Maui.Handlers;

namespace CatsGallery.Handlers
{
    public partial class Handlers : EntryHandler
    {
        protected override void ConnectHandler(Microsoft.UI.Xaml.Controls.TextBox platformView)
        {
            base.ConnectHandler(platformView);

            platformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(1);
            platformView.BorderBrush = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Gray);
            platformView.CornerRadius = new Microsoft.UI.Xaml.CornerRadius(5);
            platformView.Background = null;

            var margin = new Microsoft.UI.Xaml.Thickness(5, 0, 5, 10);
            platformView.Margin = margin;

            platformView.GotFocus += (sender, args) =>
            {
                platformView.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.LightGray);
            };

            platformView.LostFocus += (sender, args) =>
            {
                platformView.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.White);
            };
        }
    }
}
#endif
