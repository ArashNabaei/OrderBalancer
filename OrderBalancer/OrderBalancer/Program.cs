using OrderBalancer.Data;
using OrderBalancer.Services.Implements;

public class Program
{
    public static async Task Main(string[] args)
    {
        var productionUnits = Data.CreateProductionUnitData();

        var orders = Data.CreateOrderData();

        var distributor = new OrderDistributor(productionUnits);

        foreach (var order in orders)
        {
            await distributor.DistributeOrder(order);
        }

        distributor.PrintStatus();

        await Task.Delay(20000);

        distributor.PrintStatus();
    }
}
