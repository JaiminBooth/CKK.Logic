using CKK.Logic.Models;
using Xunit.Abstractions;

namespace CKKTesting
{
    public class ShoppingCartTests
    {

        [Fact]
        public void AddProductTest()
        {
            Customer cust = new Customer();
            Product prod = new Product();
            prod.SetId(44);
            ShoppingCartItem item = new ShoppingCartItem(prod, 1);
            ShoppingCart customer = new ShoppingCart(cust);
            var expected = 44;
            var actual = customer.AddProduct(prod, 1).GetProduct().GetId();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RemoveProductTest()
        {
            Customer cust = new Customer();
            Product prod = new Product();
            prod.SetId(44);
            ShoppingCartItem item = new ShoppingCartItem(prod, 1);
            ShoppingCart customer = new ShoppingCart(cust);
            var expected = 44;
            var actual = customer.RemoveProduct(prod, 1).GetProduct().GetId();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetTotalTest()
        {

            ShoppingCart cart = new ShoppingCart(new Customer());
            for (int i = 0; i < 3; i++)
            {
                Product product = new Product();
                product.SetName("s" + i);
                product.SetId(i);
                product.SetPrice(1.50m);
                cart.AddProduct(product);

            }
            Assert.Equal(4.50m, cart.GetTotal());
        }
        [Fact]
        public void GetCustomerTest()
        {
            Customer customer = new Customer();
            customer.SetName("Mark");
            customer.SetId(32);

            ShoppingCart cart = new ShoppingCart(customer);
            int item = cart.GetCustomerId();
            Assert.Equal(32, item);
            Assert.Equal("Mark", customer.GetName());
        }
    }
}