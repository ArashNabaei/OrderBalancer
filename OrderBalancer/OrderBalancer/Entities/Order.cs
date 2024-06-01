
namespace OrderBalancer.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Food> Foods { get; set; }

        public int ProcessingTime { get; set; }

        public Order(int id, List<Food> foods, int processingTime)
        {
            Foods = foods;
            Id = id;
            ProcessingTime = processingTime;
        }

        public override string ToString()
        {
            return "Order number " + Id + ", that takes " + ProcessingTime + " seconds.";
        }

    }
}
