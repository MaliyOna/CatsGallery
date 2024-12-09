using CatsGallery.ViewModels;

namespace CatsGallery.Views;

public partial class AddedCatsPage : ContentPage
{
    private readonly CatsViewModel _viewModel;

    public AddedCatsPage(CatsViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    private void OnAddCatClicked(object sender, EventArgs e)
    {
        _viewModel.AddCat();
    }
}
