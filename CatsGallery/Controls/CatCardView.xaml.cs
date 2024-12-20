using CatsGallery.Models;
using System.Windows.Input;

namespace CatsGallery.Controls
{
    public partial class CatCardView : ContentView
    {
        public static readonly BindableProperty CatDataProperty =
            BindableProperty.Create(
                nameof(CatData),
                typeof(CatModel),
                typeof(CatCardView));

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(
                nameof(Command),
                typeof(ICommand),
                typeof(CatCardView));

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public CatModel CatData
        {
            get => (CatModel)GetValue(CatDataProperty);
            set => SetValue(CatDataProperty, value);
        }

        public CatCardView()
        {
            InitializeComponent();
        }
    }
}
