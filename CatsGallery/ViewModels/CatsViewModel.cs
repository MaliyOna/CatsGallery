using CatsGallery.Abstractions;
using CatsGallery.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CatsGallery.ViewModels;

public class CatsViewModel : ObservableObject
{
    private ObservableCollection<CatModel> _cats;
    private readonly ICatsService _catService;

    public ObservableCollection<CatModel> Cats
    {
        get => _cats;
        set => SetProperty(ref _cats, value);
    }

    public CatsViewModel(ICatsService catService)
    {
        _catService = catService;
        LoadCats();
    }

    private void LoadCats()
    {
        var cats = _catService.GetCats();
        Cats = new ObservableCollection<CatModel>(cats);
    }
}
