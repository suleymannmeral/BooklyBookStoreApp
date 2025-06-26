using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Domain.Entitites;
namespace BooklyBookStoreApp.Application.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges);
        Task<BookDto> GetOneBookByIdAsync(int id,bool trackChanges);
        Task<BookDto> CreateBookAsync(CreateBookDto createBookDto);
        Task DeleteBookAsync(int id, bool trackChanges);
        Task UpdateBookAsync(int id, UpdateBookDto updateBookDto, bool trackChanges);
        

    }
}
