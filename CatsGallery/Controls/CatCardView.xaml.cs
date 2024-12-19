namespace CatsGallery.Controls
{
    public partial class CatCardView : ContentView
    {
        public static readonly BindableProperty CatModelProperty =
            BindableProperty.Create(nameof(CatModel), typeof(object), typeof(CatCardView), propertyChanged: OnCatModelChanged);

        public object CatModel
        {
            get => GetValue(CatModelProperty);
            set => SetValue(CatModelProperty, value);
        }

        public CatCardView()
        {
            InitializeComponent();
        }

        private static void OnCatModelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CatCardView)bindable;
            control.BindingContext = newValue;
        }
    }
}
