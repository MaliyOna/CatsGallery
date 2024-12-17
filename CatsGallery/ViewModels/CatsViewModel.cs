using CatsGallery.Abstractions;
using CatsGallery.CollectionViews;
using CatsGallery.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
namespace CatsGallery.ViewModels;

public class CatsViewModel
{
    public ICommand AddCatCommand { get; }
    public ICommand FilterCatsCommand { get; }
    public ICommand OpenImageCommand { get; }

    private readonly IPopupService _popupService;

    private ObservableCollection<CatModel> _cats;
    private ObservableCollection<CatModel> _filteredCats;
    private readonly ICatsService _catService;

    private string _newCatName = string.Empty;
    private string _newCatDescription = string.Empty;

    private string _searchText = string.Empty;

    public string SearchText
    {
        get => _searchText;
        set => _searchText = value;
    }

    public ObservableCollection<CatModel> Cats
    {
        get => _cats;
        set => _cats = value;
    }

    public ObservableCollection<CatModel> FilteredCats
    {
        get => _filteredCats;
        set => _filteredCats = value;
    }

    public CatsViewModel(ICatsService catService, IPopupService popupService)
    {
        _popupService = popupService;

        FilterCatsCommand = new Command<object>(FilterCats);
        OpenImageCommand = new Command<CatModel>(OpenImagePopup);
        _catService = catService;
        LoadCats();

        AddCatCommand = new Command(AddCat);
    }

    private void LoadCats()
    {
        var cats = _catService.GetCats();
        Cats = new ObservableCollection<CatModel>(cats);
        FilteredCats = new ObservableCollection<CatModel>(cats);
    }

    private void FilterCats(object searchText)
    {
        var text = searchText as string ?? string.Empty;

        if (string.IsNullOrWhiteSpace(text))
        {
            FilteredCats = new ObservableCollection<CatModel>(Cats);
        }
        else
        {
            FilteredCats.Clear();

            var filtered = Cats.Where(cat => cat.Name.Contains(text, StringComparison.OrdinalIgnoreCase));

            foreach (var cat in filtered)
            {
                FilteredCats.Add(cat);
            }
        }
    }

    public string NewCatName
    {
        get => _newCatName;
        set => _newCatName = value;
    }

    public string NewCatDescription
    {
        get => _newCatDescription;
        set => _newCatDescription = value;
    }

    public void AddCat()
    {
        var newCat = new CatModel
        {
            Name = NewCatName,
            Description = NewCatDescription,
            ImageSource = "cat5.jpg"
        };
        Cats.Add(newCat);
        FilteredCats.Add(newCat);
        NewCatName = string.Empty;
        NewCatDescription = string.Empty;
    }

    private async void OpenImagePopup(CatModel cat)
    {
        await _popupService.ShowPopupAsync<CatImagePopup>(cat);

    }
}
