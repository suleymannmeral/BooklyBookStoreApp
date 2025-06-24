using BooklyBookStoreApp.Domain.Entitites;

namespace BooklyBookStoreApp.Application.Services
{
    public interface IBookService
    {
        Task CreateAsync(Dto t);
    }
}
