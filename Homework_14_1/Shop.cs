
namespace Homework_14_1
{
    public class Shop
    {
        private List<Product> productList = new List<Product>();
        public void AddProduct(Product product)
        {
            productList.Add(product);
        }
        public void RemoveProduct(int productId)
        {
            productList.RemoveAt(productId);
        }

        public void GetProductById(int productId)
        {
            var product = productList.Find(product => product.Id == productId);
            Console.WriteLine($"Name: {product.Name} | Price: {product.Price}");
        }

        public List<Product> GetAllProducts()
        {
            return productList;
        }
    }
}