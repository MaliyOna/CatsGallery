using CatsGallery.ViewModels;

namespace CatsGallery.Views;

public partial class AddedCatsPage : ContentPage
{
    public AddedCatsPage(CatsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
