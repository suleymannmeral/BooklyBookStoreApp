using AutoMapper;
using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Domain.Repositories;

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

        public Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges)
        {
            throw new NotImplementedException();
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
