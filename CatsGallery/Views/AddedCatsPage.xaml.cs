using CatsGallery.ViewModels;

namespace CatsGallery.Views;

public partial class AddedCatsPage : ContentPage
{
    public AddedCatsPage(CatsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private void OnNameTextChanged(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is CatsViewModel viewModel)
        {
            viewModel.NewCatName = e.NewTextValue;
        }
    }

    private void OnDescriptionTextChanged(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is CatsViewModel viewModel)
        {
            viewModel.NewCatDescription = e.NewTextValue;
        }
    }
}
