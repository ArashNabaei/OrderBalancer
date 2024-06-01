using OrderBalancer.Entities;
using OrderBalancer.Services.Implements;

public class Program
{
    public static async Task Main(string[] args)
    {
        var productionUnits = new List<ProductionUnit>
        {
            new ProductionUnit(1, "Unit 1", 1),
            new ProductionUnit(2, "Unit 2", 1),
            new ProductionUnit(3, "Unit 3", 1)
        };

        var orders = new List<Order>
        {
            new Order(1, new List<Food> { new Food("Pizza", 10), new Food("Salad", 5) }, 3),
            new Order(2, new List<Food> { new Food("Burger", 8), new Food("Fries", 3) }, 2),
            new Order(3, new List<Food> { new Food("Sushi", 15) }, 5),
            new Order(4, new List<Food> { new Food("Pasta", 12) }, 3)
        };

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