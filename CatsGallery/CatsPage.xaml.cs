using CatsGallery.ViewModels;

namespace CatsGallery;

public partial class CatsPage : ContentPage
{
    public CatsPage(CatsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}