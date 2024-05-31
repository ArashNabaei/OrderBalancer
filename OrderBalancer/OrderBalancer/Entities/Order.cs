
namespace OrderBalancer.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Food> Foods { get; set; }

        public int ProcessingTime { get; set; }

    }
}
