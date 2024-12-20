using Mopups.Pages;
using Mopups.Services;

namespace CatsGallery.CollectionViews
{
    public partial class CatImagePopup : PopupPage
    {
        public CatImagePopup()
        {
            InitializeComponent();
        }

        private async void ClosePopup(object sender, EventArgs e)
        {
            await MopupService.Instance.PopAsync();
        }
    }
}