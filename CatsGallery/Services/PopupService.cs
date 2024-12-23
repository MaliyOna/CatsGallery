using CatsGallery.Abstractions;
using Mopups.Pages;
using Mopups.Services;

namespace CatsGallery.Services;

public class PopupService : IPopupService
{
    public async Task ShowPopupAsync<TPopup>(object parameter = null) where TPopup : PopupPage, new()
    {
        var popup = new TPopup();
        if (parameter != null)
        {
            popup.BindingContext = parameter;
        }
        await MopupService.Instance.PushAsync(popup);
    }

    public async Task ClosePopupAsync()
    {
        await MopupService.Instance.PopAsync();
    }
}
