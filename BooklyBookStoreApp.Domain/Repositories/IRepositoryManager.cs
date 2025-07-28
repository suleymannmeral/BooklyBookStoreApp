namespace BooklyBookStoreApp.Domain.Repositories;

public interface IRepositoryManager                          // Repoları Buradan Yöneteceğiz
{
    IBookRepository Book { get; }
    ICategoryRepository Category { get; }
    IFavoriteRepository Favorite { get; }
    Task Save();


}
