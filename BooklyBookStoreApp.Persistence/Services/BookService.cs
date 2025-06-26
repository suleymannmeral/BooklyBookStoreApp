using AutoMapper;
using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Domain.Repositories;
using BooklyBookStoreApp.Persistence.Repositorires;
using Microsoft.EntityFrameworkCore;

namespace BooklyBookStoreApp.Persistence.Services
{
    public sealed class BookService : IBookService
    {
       private readonly IRepositoryManager _repositoryManager;

        private readonly IMapper _mapper;

        public BookService(IMapper mapper, IRepositoryManager repositoryManager)
        {

            _mapper = mapper;
            _repositoryManager = repositoryManager;
        }

        public Task<BookDto> CreateBookAsync(CreateBookDto createBookDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GetBookDto>> GetAllBooksAsync(bool trackChanges)
        {
                var books = await _repositoryManager.Book
            .GetAllBooks(trackChanges)
            .Include(b => b.Category)
            .ToListAsync();

            return _mapper.Map<IEnumerable<GetBookDto>>(books);
        }

        public Task<BookDto> GetOneBookByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBookAsync(int id, UpdateBookDto updateBookDto, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
