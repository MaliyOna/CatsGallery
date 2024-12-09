namespace CatsGallery.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void ToCatsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///CatsPage");
    }

    private async void ToFindCatClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///FilteredCatsPage");
    }

    private async void ToAddCatClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///AddedCatsPage");
    }
}
