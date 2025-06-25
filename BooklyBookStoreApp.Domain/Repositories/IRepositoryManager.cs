namespace BooklyBookStoreApp.Domain.Repositories;

public interface IRepositoryManager                          // Repoları Buradan Yöneteceğiz
{
    IBookRepository Book { get; }
    void Save();


}
