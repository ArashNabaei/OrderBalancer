using OrderBalancer.Entities;

namespace OrderBalancer.Services.Implements
{
    public class ProductionUnit
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Capacity { get; set; }

        public bool IsBusy { get; set; }

        private Order? CurrentOrder { get; set; }

    }
}
