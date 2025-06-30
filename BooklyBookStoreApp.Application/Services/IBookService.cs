using BooklyBookStoreApp.Application.DTOs.BookDtos;
namespace BooklyBookStoreApp.Application.Services;

public interface IBookService
{
    Task<IEnumerable<GetBookDto>> GetAllBooksAsync(bool trackChanges);
    Task<GetBookDto> GetOneBookByIdAsync(int id,bool trackChanges);
    Task<BookDto> CreateBookAsync(CreateBookDto createBookDto);
    Task DeleteBookAsync(int id, bool trackChanges);
    Task UpdateBookAsync(int id, UpdateBookDto updateBookDto, bool trackChanges);
   



}
