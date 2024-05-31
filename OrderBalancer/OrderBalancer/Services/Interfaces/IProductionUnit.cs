using OrderBalancer.Entities;

namespace OrderBalancer.Services.Interfaces
{
    public interface IProductionUnit
    {
        bool IsBusy { get; }

        void AddOrder(Order order);

        bool CanTakeOrder();

        string Status();

        Task Ordering();

    }
}
