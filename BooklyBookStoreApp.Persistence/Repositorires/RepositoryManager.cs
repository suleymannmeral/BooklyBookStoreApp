using BooklyBookStoreApp.Domain.Repositories;
using BooklyBookStoreApp.Persistence.Context;

namespace BooklyBookStoreApp.Persistence.Repositorires;

public class RepositoryManager : IRepositoryManager         //unit of work pattern  RepositoryManager, birden fazla repository'yi yöneten bir sınıf
{
    private readonly AppDbContext _context;
    private readonly Lazy<IBookRepository> _bookRepository;          // 

    public RepositoryManager(AppDbContext context)
    {
        _context = context;
        _bookRepository= new Lazy<IBookRepository>(() => new BookRepository(context)); 
    }

    public IBookRepository Book => _bookRepository.Value;          // newlenmis hali donuelcek nesne kullanıldıgı anda ilgili ifade newlenir

    public async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}
