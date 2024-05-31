using OrderBalancer.Entities;

namespace OrderBalancer.Services.Interfaces
{
    public interface IOrderDistributor
    {
        void DistributeOrder(Order order);

        void PrintStatus();

    }
}
