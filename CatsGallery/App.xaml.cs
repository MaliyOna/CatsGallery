namespace CatsGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Handlers.Handlers.RegisterHandlers();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}