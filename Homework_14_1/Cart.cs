namespace Homework_14_1
{
    public class Cart
    {
        private List<Product> myCart = new List<Product>();
        public void AddToCart(Product product)
        {
            myCart.Add(product);
        }
        public void RemoveFromCart(int productId)
        {
            myCart.RemoveAll(product => product.Id == productId);
        }
        public double GetTotalPrice()
        {
            return myCart.Sum(p => p.Price);
        }

    }
}