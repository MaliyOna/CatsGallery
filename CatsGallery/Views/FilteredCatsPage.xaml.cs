using CatsGallery.ViewModels;

namespace CatsGallery.Views;

public partial class FilteredCatsPage : ContentPage
{
    public FilteredCatsPage(CatsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
