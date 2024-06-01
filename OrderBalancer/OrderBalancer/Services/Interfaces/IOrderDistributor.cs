using OrderBalancer.Entities;

namespace OrderBalancer.Services.Interfaces
{
    public interface IOrderDistributor
    {
        Task DistributeOrder(Order order);

        void PrintStatus();

    }
}
