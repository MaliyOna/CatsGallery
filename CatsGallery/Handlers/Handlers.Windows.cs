using Microsoft.Maui.Handlers;

namespace CatsGallery.Handlers
{
    public partial class Handlers : EntryHandler
    {
        protected override void ConnectHandler(Microsoft.UI.Xaml.Controls.TextBox platformView)
        {
            base.ConnectHandler(platformView);

            if (VirtualView is Entry entry && entry.StyleId == "Custom")
            {
                platformView.Style = null;

                platformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(1);
                platformView.BorderBrush = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Gray);
                platformView.CornerRadius = new Microsoft.UI.Xaml.CornerRadius(5);
                platformView.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.White);
                platformView.Margin = new Microsoft.UI.Xaml.Thickness(5, 0, 5, 10);

                platformView.FocusVisualPrimaryBrush = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Transparent);
                platformView.FocusVisualSecondaryBrush = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Transparent);

                platformView.GotFocus += (sender, args) =>
                {
                    platformView.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.LightGray);

                    platformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
                    platformView.BorderBrush = null;
                };

                platformView.LostFocus += (sender, args) =>
                {
                    platformView.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.White);
                    platformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(1);
                    platformView.BorderBrush = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Gray);
                };
            }
        }
    }
}
