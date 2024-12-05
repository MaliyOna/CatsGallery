using CatsGallery.Models;
using System.Collections.ObjectModel;

namespace CatsGallery.ViewModels;

public class CatsViewModel
{
    public ObservableCollection<CatModel> Cats { get; private set; }

    public CatsViewModel()
    {
        Cats = new ObservableCollection<CatModel>
        {
                new CatModel { Name = "Мурзик", Description = "Самый уютный кот в городе", ImageSource = "cat1.jpg" },
                new CatModel { Name = "Барсик", Description = "Охотник за приключениями", ImageSource = "cat2.jpg" },
                new CatModel { Name = "Пушок", Description = "Облачко мягкости", ImageSource = "cat3.jpg" },
                new CatModel { Name = "Симба", Description = "Король ленивого воскресенья", ImageSource = "cat4.jpg" }
            };
    }
}
