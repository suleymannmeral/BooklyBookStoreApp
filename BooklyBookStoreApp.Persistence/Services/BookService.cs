using AutoMapper;
using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BooklyBookStoreApp.Persistence.Services;

public sealed class BookService : IBookService
{
   private readonly IRepositoryManager _repositoryManager;

    private readonly IMapper _mapper;

    public BookService(IMapper mapper, IRepositoryManager repositoryManager)
    {

        _mapper = mapper;
        _repositoryManager = repositoryManager;
    }

    private async Task<Book> CheckBookExist(int id, bool trackChanges)
    {
        var book = await _repositoryManager.Book.GetOneBookByIdAsync(id, trackChanges);
        if (book is null)
        {
            throw new ArgumentException("Book not found");   
        }
        return book;

    }

    public async Task<BookDto> CreateBookAsync(CreateBookDto createBookDto)
    {
        var book = _mapper.Map<Book>(createBookDto);
        _repositoryManager.Book.Create(book);
        await _repositoryManager.Save();
        return _mapper.Map<BookDto>(book);
    }

    public async Task DeleteBookAsync(int id, bool trackChanges)
    {
        var book = await CheckBookExist(id, trackChanges);
        _repositoryManager.Book.Delete(book);
        await _repositoryManager.Save();
    }

    public async Task<IEnumerable<GetBookDto>> GetAllBooksAsync(bool trackChanges)
    {
            var books = await _repositoryManager.Book
            .GetAllBooks(trackChanges)
            .Include(b => b.Category)
            .ToListAsync();

        return _mapper.Map<IEnumerable<GetBookDto>>(books);
    }

    public async Task<GetBookDto> GetOneBookByIdAsync(int id, bool trackChanges)
    {
        var book = await CheckBookExist(id, false);
        return _mapper.Map<GetBookDto>(book);
    }

    public async Task UpdateBookAsync(int id, UpdateBookDto updateBookDto, bool trackChanges)
    {
        var book = await CheckBookExist(id, false); 
        _mapper.Map(updateBookDto, book); // yeni nesne oluşturma, var olan nesneye map et
        _repositoryManager.Book.Update(book);
        await _repositoryManager.Save();

    }

    public async Task<GetBookDto> GetOneBookByIdWithCategoryAsync(int id, bool trackChanges)
    {
        var book = await _repositoryManager.Book.GetOneBookByIdWithCategoryAsync(id, trackChanges);
        if (book is null)
            throw new ArgumentException($"Book with ID {id} not found.");
        return _mapper.Map<GetBookDto>(book);
    }
}
