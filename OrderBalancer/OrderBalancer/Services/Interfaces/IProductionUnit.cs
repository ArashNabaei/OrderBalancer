using OrderBalancer.Entities;

namespace OrderBalancer.Services.Interfaces
{
    public interface IProductionUnit
    {

        Task AddOrder(Order order);

        Task<bool> CanTakeOrder();

        Task<string> Status();

        Task Ordering();

    }
}
