using CatsGallery.ViewModels;

namespace CatsGallery.Views;

public partial class AddedCatsPage : ContentPage
{
    private readonly CatsViewModel _catsViewModel;

    public AddedCatsPage(CatsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        _catsViewModel = viewModel;
    }

    private void OnNameTextChanged(object sender, TextChangedEventArgs e)
    {
        if (_catsViewModel != null)
            _catsViewModel.NewCatName = e.NewTextValue;
    }

    private void OnDescriptionTextChanged(object sender, TextChangedEventArgs e)
    {
        if (_catsViewModel != null)
            _catsViewModel.NewCatDescription = e.NewTextValue;
    }
}
