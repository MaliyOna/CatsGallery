using CatsGallery.ViewModels;

namespace CatsGallery.Views;

public partial class CatsPage : ContentPage
{
    public CatsPage(CatsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}