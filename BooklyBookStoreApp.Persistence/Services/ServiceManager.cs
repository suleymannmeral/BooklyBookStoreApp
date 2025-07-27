using AutoMapper;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Repositories;

namespace BooklyBookStoreApp.Persistence.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IBookService> _bookService;
    private readonly Lazy<ICategoryService> _categoryService;
    public ServiceManager(IMapper mapper, IRepositoryManager manager)
    {
        _bookService = new Lazy<IBookService>(() => new BookService(mapper,manager));
        _categoryService = new Lazy<ICategoryService>(() => new CategoryService(manager,mapper));
    }

    public IBookService BookService => _bookService.Value;
    public ICategoryService CategoryService => _categoryService.Value;
}
