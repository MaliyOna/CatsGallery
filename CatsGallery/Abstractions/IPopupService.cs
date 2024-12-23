using Mopups.Pages;

namespace CatsGallery.Abstractions;

public interface IPopupService
{
    Task ShowPopupAsync<TPopup>(object parameter = null) where TPopup : PopupPage, new();
    Task ClosePopupAsync();
}
