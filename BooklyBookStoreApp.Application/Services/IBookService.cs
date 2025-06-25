using BooklyBookStoreApp.Application.DTOs.BookDtos;
namespace BooklyBookStoreApp.Application.Services
{
    public interface IBookService
    {
        Task CreateAsync(CreateBookDto createBookDTo);
    }
}
