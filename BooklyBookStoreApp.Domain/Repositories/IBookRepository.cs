using BooklyBookStoreApp.Domain.Entitites;


namespace BooklyBookStoreApp.Domain.Repositories;

public  interface IBookRepository:IRepositoryBase<Book>
{
    IQueryable<Book> GetAllBooks(bool trackChanges);
    IQueryable<Book> GetOneBookById(int id, bool trackChanges);
    Task CreateBook(Book book);
    Task  UpdateBook(Book book);
    Task DeleteBook(Book book);

}
