using CatsGallery.Abstractions;
using CatsGallery.Models;

namespace CatsGallery.Services;
public class CatsService : ICatsService
{
    public List<CatModel> GetCats() => new() {
        new CatModel { Name = "Мурзик", Description = "Самый уютный кот в городе", ImageSource = "cat1.jpg" },
        new CatModel { Name = "Барсик", Description = "Охотник за приключениями", ImageSource = "cat2.jpg" },
        new CatModel { Name = "Пушок", Description = "Облачко мягкости", ImageSource = "cat3.jpg" },
        new CatModel { Name = "Симба", Description = "Король ленивого воскресенья", ImageSource = "cat4.jpg" },
        new CatModel { Name = "Симба", Description = "Король ленивого воскресенья", ImageSource = "cat4.jpg" },
        new CatModel { Name = "Симба", Description = "Король ленивого воскресенья. Симба любит долгие дремоты под солнцем и игры на свежем воздухе. Его любимые занятия включают преследование бабочек, наблюдение за птицами с окна и долгие прогулки по дому в поисках идеального места для сна.",  ImageSource = "cat4.jpg" }
    };
}
