using BooklyBookStoreApp.Domain.Entitites;


namespace BooklyBookStoreApp.Domain.Repositories;

public interface IOrderRepository: IRepositoryBase<Order>
{
    IQueryable<Order> GetAllOrdersByUserId(bool trackChanges);
    IQueryable<Order> GetOneOrderByIdAndUserId(int id, bool trackChanges);
    void CreateOrder(Order order);
    void UpdateOrder(Order order);
    void DeleteOrder(Order order);
}
