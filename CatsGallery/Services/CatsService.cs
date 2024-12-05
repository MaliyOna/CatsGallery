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
        new CatModel { Name = "Симба", Description = "Король ленивого воскресенья", ImageSource = "cat4.jpg" }
    };
}
