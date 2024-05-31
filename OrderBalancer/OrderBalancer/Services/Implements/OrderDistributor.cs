using OrderBalancer.Entities;
using OrderBalancer.Services.Interfaces;

namespace OrderBalancer.Services.Implements
{
    public class OrderDistributor : IOrderDistributor
    {

        private List<IProductionUnit> _productionUnits { get; set; }

        private int _currentUnit { get; set; }

        public OrderDistributor(List<IProductionUnit> productionUnits)
        {
            _productionUnits = productionUnits;
        }

        public void DistributeOrder(Order order)
        {
            var unit = _productionUnits[_currentUnit];
            _currentUnit = (_currentUnit + 1) % _productionUnits.Count;

            unit.AddOrder(order);

            if (!unit.IsBusy)
                Task.Run(() => unit.Ordering());
        }

        public void PrintStatus()
        {
            foreach (var unit in _productionUnits)
            {
                Console.WriteLine(unit.Status());
            }
        }

    }
}
