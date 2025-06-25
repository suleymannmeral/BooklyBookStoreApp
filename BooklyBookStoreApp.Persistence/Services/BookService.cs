using AutoMapper;
using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Persistence.Context;


namespace BooklyBookStoreApp.Persistence.Services
{
    public sealed class BookService : IBookService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public BookService(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task CreateAsync(CreateBookDto createBookDto)
        {
            //Book book = new()
            //{
            //    Title = createBookDto.Title,
            //    Description = createBookDto.Description,
            //    Price = createBookDto.Price,
            //    PictureURl = createBookDto.PictureURl,
            //    Author = createBookDto.Author,
            //    CategoryID = createBookDto.CategoryID
            //};

            Book book = _mapper.Map<Book>(createBookDto);


            await _appDbContext.Set<Book>().AddAsync(book); // memorye ekler
            await _appDbContext.SaveChangesAsync();           // veritabanına ekler



        }
    }
}
