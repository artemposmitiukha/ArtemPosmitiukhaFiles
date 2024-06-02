namespace Homework_14_1
{
    public class Product
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Id = new Random().Next(100);
        }

    }
}