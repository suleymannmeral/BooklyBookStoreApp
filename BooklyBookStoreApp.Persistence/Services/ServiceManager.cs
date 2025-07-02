using AutoMapper;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Repositories;

namespace BooklyBookStoreApp.Persistence.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IBookService> _bookService;
    public ServiceManager(IMapper mapper, IRepositoryManager manager)
    {
        _bookService = new Lazy<IBookService>(() => new BookService(mapper,manager));
    }

    public IBookService BookService => _bookService.Value;
}
