#if ANDROID
using Microsoft.Maui.Handlers;

namespace CatsGallery.Handlers
{
    public partial class Handlers : EntryHandler
    {
        protected override void ConnectHandler(Microsoft.UI.Xaml.Controls.TextBox platformView)
        {
            base.ConnectHandler(platformView);
        }
    }
}
#endif
