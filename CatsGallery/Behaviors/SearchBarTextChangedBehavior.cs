using System.Windows.Input;

namespace CatsGallery.Behaviors;

public class SearchBarTextChangedBehavior : Behavior<SearchBar>
{
    public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(SearchBarTextChangedBehavior));

    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    protected override void OnAttachedTo(SearchBar bindable)
    {
        base.OnAttachedTo(bindable);
        bindable.TextChanged += OnSearchBarTextChanged;
    }

    protected override void OnDetachingFrom(SearchBar bindable)
    {
        bindable.TextChanged -= OnSearchBarTextChanged;
        base.OnDetachingFrom(bindable);
    }

    private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
    {
        if (Command?.CanExecute(e.NewTextValue) ?? false)
        {
            Command.Execute(e.NewTextValue);
        }
    }
}
