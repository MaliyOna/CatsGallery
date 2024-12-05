namespace CatsGallery
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///CatsPage");
        }
    }
}
