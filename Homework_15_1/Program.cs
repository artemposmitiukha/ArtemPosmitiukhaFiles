namespace Homework_15_1;

class Program
{
    static void Main(string[] args)
    {
        List<int> list_1 = new List<int>(){2, 5, 8, 12, 15, 18, 22};
        var moreThan = list_1.Where(num => num > 10);
        foreach (var num in moreThan)
            Console.WriteLine("Number more than 10: " + num);
        
        Console.WriteLine("----------------------------------");
        
        List<string> list_2 = new List<string>() { "Яблуко", "Апельсин", "Банан", "Ківі" };
        list_2.Sort();
        foreach (var str in list_2)
            Console.WriteLine(str);
        
        Console.WriteLine("----------------------------------");
        
        List<string> list_3 = new List<string>() { "А", "Б", "В", "А", "Г", "В" };
        List<string> list_3_buffer = list_3.Distinct().ToList();
        foreach (var str in list_3_buffer)
            Console.WriteLine("Unique string: " + str);
        
        Console.WriteLine("----------------------------------");
        
        List<int> list_4 = new List<int>() { 85, 92, 78, 95, 88, 90 };
        int list_4_count = list_4.Count(num => num > 90);
        Console.WriteLine("More than 90: " + list_4_count);
        
        Console.WriteLine("----------------------------------");
        
        Product product_1 = new Product("Apple", 78);
        Product product_2 = new Product("Toy", 34);
        Product product_3 = new Product("Car", 23);
        Product product_4 = new Product("Robot", 45);

        List<Product> list_5 = new List<Product>(){product_1, product_2, product_3, product_4};
        var priceCheck = list_5.Where(num => num.Price < 50).ToList();
        var sortProducts = priceCheck.OrderBy(product => product.Price).ToList();

        foreach (var product in sortProducts)
            Console.WriteLine($"Name: {product.Name} | Price: {product.Price}");
        
        Console.WriteLine("----------------------------------");
        
        List<int> list_6 = new List<int>() { 10, 25, 8, 45, 15, 30, 55, 5 };
        Console.WriteLine("Max number: " + list_6.Max());
    }
}