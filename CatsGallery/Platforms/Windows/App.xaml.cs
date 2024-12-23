using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CatsGallery.WinUI
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : MauiWinUIApplication
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderlineWindows", (handler, view) =>
            {
                if (handler.PlatformView is TextBox textBox)
                {
                    var style = new Microsoft.UI.Xaml.Style(typeof(TextBox));
                    style.Setters.Add(new Microsoft.UI.Xaml.Setter(TextBox.BorderThicknessProperty, new Microsoft.UI.Xaml.Thickness(0)));
                    textBox.Style = style;
                }
            });
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }

}
