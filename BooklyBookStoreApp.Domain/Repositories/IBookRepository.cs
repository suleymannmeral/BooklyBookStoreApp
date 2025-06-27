using BooklyBookStoreApp.Domain.Entitites;


namespace BooklyBookStoreApp.Domain.Repositories;

public  interface IBookRepository:IRepositoryBase<Book>
{
    IQueryable<Book> GetAllBooks(bool trackChanges);
    Task<Book> GetOneBookByIdAsync(int id, bool trackChanges);
    void CreateBook(Book book);
    void UpdateBook(Book book);
    void DeleteBook(Book book);

}
