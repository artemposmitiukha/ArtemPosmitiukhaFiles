namespace Homework_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", 34);
            var toy = new Product("Toy", 43);
            var car = new Product("Car", 78);
            var cloth = new Product("Cloth", 87);
            Shop shop = new Shop();
            shop.AddProduct(apple);
            shop.AddProduct(toy);
            shop.AddProduct(car);
            shop.AddProduct(cloth);
            foreach (var product in shop.GetAllProducts())
            {
                Console.WriteLine($"ID: {product.Id} | Name: {product.Name} | Price: {product.Price}$");
            }
            Cart cart = new Cart();
            cart.AddToCart(car);
            cart.AddToCart(cloth);
            cart.AddToCart(apple);
            Console.WriteLine($"Total price: {cart.GetTotalPrice()}$");
            cart.RemoveFromCart(apple.Id);
            Console.WriteLine($"Total price: {cart.GetTotalPrice()}$");


        }
    }
}