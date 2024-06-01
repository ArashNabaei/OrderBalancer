using OrderBalancer.Entities;
using OrderBalancer.Services.Interfaces;

namespace OrderBalancer.Services.Implements
{
    public class ProductionUnit : IProductionUnit
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Capacity { get; set; }

        public bool IsBusy { get; set; }

        private Order? CurrentOrder { get; set; }

        public ProductionUnit(int id, string name, int capacity)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            IsBusy = false;
        }

        public void AddOrder(Order order)
        {
            if (CanTakeOrder())
            {
                CurrentOrder = order;
                IsBusy = true;
            }

        }

        public bool CanTakeOrder()
        {
            return !IsBusy;
        }

        public async Task Ordering()
        {
            Console.WriteLine($"{Name} is processing order {CurrentOrder}");

            await Task.Delay(CurrentOrder.ProcessingTime * 1000);

            Console.WriteLine($"{Name} has finished processing order {CurrentOrder}");

            IsBusy = false;
            CurrentOrder = null;

        }

        public string Status()
        {
            return "Production Unit : " + Id + " Name: " + Name;
        }

    }
}
