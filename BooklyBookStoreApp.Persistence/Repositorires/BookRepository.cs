using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Domain.Repositories;
using BooklyBookStoreApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BooklyBookStoreApp.Persistence.Repositorires;

public sealed class BookRepository : RepositoryBase<Book>, IBookRepository
{
    public BookRepository(AppDbContext context) : base(context)
    {
      
    }

    public void CreateBook(Book book) => Create(book);
    public void DeleteBook(Book book)=>Delete(book);
    public IQueryable<Book> GetAllBooks(bool trackChanges) =>
        FindAll(trackChanges);
    public Task<Book> GetOneBookByIdAsync(int id, bool trackChanges) =>
        FindByCondition(b => b.Id.Equals(id), trackChanges)
        .SingleOrDefaultAsync();
    public void UpdateBook(Book book)=>Update(book);
}
