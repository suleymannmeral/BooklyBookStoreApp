namespace BooklyBookStoreApp.Domain.Repositories;

public interface IRepositoryManager                          // Managing multiple repositories in a single class, implementing the Unit of Work pattern
{
    IBookRepository Book { get; }
    ICategoryRepository Category { get; }
    IFavoriteRepository Favorite { get; }
    IBasketRepository Basket { get; }
    IOrderRepository Order { get; }
    
    Task Save();


}
