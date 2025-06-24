using BooklyBookStoreApp.Application;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Persistence.Context;


namespace BooklyBookStoreApp.Persistence.Services
{
    public sealed class BookService : IBookService
    {
        private readonly AppDbContext _appDbContext;

        public BookService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CreateAsync(Dto t)
        {
            Book book = new()
            {
                Title = t.Title,
                Description = t.Description,
                Price = t.Price,
                PictureURl = t.PictureURl,
                Author = t.Author,
                CategoryID = t.CategoryID
            };


            await _appDbContext.Set<Book>().AddAsync(book); // memorye ekler
            await _appDbContext.SaveChangesAsync();           // veritabanına ekler



        }
    }
}
