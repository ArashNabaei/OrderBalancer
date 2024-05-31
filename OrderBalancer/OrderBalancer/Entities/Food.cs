
namespace OrderBalancer.Entities
{
    public class Food
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public Food(string name, float price)
        {
            Name = name;
            Price = price;
        }

    }
}
