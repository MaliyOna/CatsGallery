using CatsGallery.Models;

namespace CatsGallery.Abstractions;

public interface ICatsService
{
    List<CatModel> GetCats();
}

