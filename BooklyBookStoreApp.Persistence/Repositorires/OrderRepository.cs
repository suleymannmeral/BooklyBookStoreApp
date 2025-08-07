using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Domain.Repositories;
using BooklyBookStoreApp.Persistence.Context;

namespace BooklyBookStoreApp.Persistence.Repositorires
{
    public sealed class OrderRepository : RepositoryBase<Order>,IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }

        public void CreateOrder(Order order)=> Create(order);

        public void DeleteOrder(Order order)=> Delete(order);


        public IQueryable<Order> GetAllOrdersByUserId(bool trackChanges)=>FindAll(trackChanges);
        public IQueryable<Order> GetOneOrderByIdAndUserId(int id, string userId, bool trackChanges) =>
            FindByCondition(b => b.Id == id && b.UserId == userId, trackChanges);

        public void UpdateOrder(Order order)=> Update(order);

    }
}
