using CatsGallery.ViewModels;

namespace CatsGallery.Views;

public partial class FilteredCatsPage : ContentPage
{
    public FilteredCatsPage(CatsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        var vm = BindingContext as CatsViewModel;
        vm?.FilterCats(e.NewTextValue);
    }
}
