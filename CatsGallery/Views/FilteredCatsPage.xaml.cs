using CatsGallery.ViewModels;

namespace CatsGallery.Views;

public partial class FilteredCatsPage : ContentPage
{
    private readonly CatsViewModel _viewModel;

    public FilteredCatsPage(CatsViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        _viewModel.FilterCats(e.NewTextValue);
    }
}
