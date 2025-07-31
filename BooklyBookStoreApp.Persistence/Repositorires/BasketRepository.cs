using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Domain.Repositories;
using BooklyBookStoreApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;


namespace BooklyBookStoreApp.Persistence.Repositorires
{
    public class BasketRepository : RepositoryBase<Basket>, IBasketRepository
    {
        public BasketRepository(AppDbContext context) : base(context)
        {
        }

        public void AddBasket(Basket basket)=>Create(basket);
       

        public void DeleteBasket(Basket basket)=>Delete(basket);
     

        public Basket GetBasketByUserIdAsync(string userId)
        {
          return  _context.Baskets
            .Include(b => b.BasketItems)
            .ThenInclude(i => i.Book)
            .FirstOrDefault(b => b.UserId == userId);
        }

        public void UpdateBasket(Basket basket)=>Update(basket);
        
    }
}
