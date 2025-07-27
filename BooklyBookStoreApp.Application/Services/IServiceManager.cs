

namespace BooklyBookStoreApp.Application.Services
{
    public interface IServiceManager
    {
        IBookService BookService { get; }
        ICategoryService CategoryService { get; }

    }
}
