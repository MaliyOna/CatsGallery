﻿using CatsGallery.Abstractions;
using CatsGallery.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CatsGallery.ViewModels;

public class CatsViewModel : INotifyPropertyChanged
{
    private ObservableCollection<CatModel> _cats;
    private ObservableCollection<CatModel> _filteredCats;
    private readonly ICatsService _catService;

    public ObservableCollection<CatModel> Cats
    {
        get => _cats;
        set
        {
            if (_cats != value)
            {
                _cats = value;
                OnPropertyChanged();
            }
        }
    }

    public ObservableCollection<CatModel> FilteredCats
    {
        get => _filteredCats;
        set
        {
            if (_filteredCats != value)
            {
                _filteredCats = value;
                OnPropertyChanged();
            }
        }
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
        FilteredCats = new ObservableCollection<CatModel>(cats);
    }

    public void FilterCats(string searchText)
    {
        if (string.IsNullOrWhiteSpace(searchText))
        {
            FilteredCats = new ObservableCollection<CatModel>(Cats);
        }
        else
        {
            FilteredCats = new ObservableCollection<CatModel>(Cats.Where(c => c.Name.ToLower().Contains(searchText.ToLower())));
        }
        OnPropertyChanged(nameof(FilteredCats));
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
