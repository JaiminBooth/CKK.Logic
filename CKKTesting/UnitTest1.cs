
using Xunit.Abstractions;

namespace CKK.Logic
{
    public class ShoppingCartTests
    {

        [Fact]
        public void AddProduct()
        {
            Product product = new Product();
            product.id = 54;
            Customer customer = new Customer();
            var expected = 1;
            ShoppingCart shCart = new ShoppingCart(customer);
            shCart.AddProduct(product);
            var actual = shCart.GetProductById(54);
            Assert.Equal(expected, actual.quantity);
        }
        [Fact]
        public void RemoveProduct()
        {
            Product product = new Product();
            product.id = 54;
            Customer customer = new Customer();
            ShoppingCart shCart = new ShoppingCart(customer);
            var expected = 44;

            shCart.AddProduct(product);
            shCart.RemoveProduct(product, 1);
            var actual = shCart.GetProductById(54);
            Assert.Equal(0, actual.quantity);
        }
        [Fact]
        public void GetTotal()
        {

            ShoppingCart cart = new ShoppingCart(new Customer());

            Product product1 = new Product();
            product1.name = "s";
            product1.id = 22;
            product1.price = 1.50m;
            cart.AddProduct(product1);

            Product product2 = new Product();
            product2.name = "g";
            product2.id = 32;
            product2.price = 1.50m;
            cart.AddProduct(product2);

            Product product3 = new Product();
            product3.name = "a";
            product3.id = 34;
            product3.price = 1.50m;
            cart.AddProduct(product3);

            Assert.Equal(4.50m, cart.GetTotal());
        }

    }
}