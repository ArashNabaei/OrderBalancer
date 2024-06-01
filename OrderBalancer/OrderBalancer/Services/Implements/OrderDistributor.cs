using OrderBalancer.Entities;
using OrderBalancer.Services.Interfaces;

namespace OrderBalancer.Services.Implements
{
    public class OrderDistributor : IOrderDistributor
    {

        private List<ProductionUnit> _productionUnits { get; set; }

        private int _currentUnit { get; set; }

        public OrderDistributor(List<ProductionUnit> productionUnits)
        {
            _productionUnits = productionUnits;
            _currentUnit = 0;
        }

        public async Task DistributeOrder(Order order)
        {
            var unit = _productionUnits[_currentUnit];
            _currentUnit = (_currentUnit + 1) % _productionUnits.Count;

            unit.AddOrder(order);

            if (unit.IsBusy)
                await unit.Ordering();
        }

    }
}
