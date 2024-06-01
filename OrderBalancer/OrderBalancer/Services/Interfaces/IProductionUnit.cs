using OrderBalancer.Entities;

namespace OrderBalancer.Services.Interfaces
{
    public interface IProductionUnit
    {

        void AddOrder(Order order);

        bool CanTakeOrder();

        Task Ordering();

    }
}
