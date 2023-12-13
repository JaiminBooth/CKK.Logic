
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic
{
    public class ShoppingCart
    {
        public Customer customer { get; set; }
        public List<ShoppingCartItem> products;

        public ShoppingCart()
        {
            products = new List<ShoppingCartItem>();
        }
        public ShoppingCart(Customer ScCustomer)
        {
            customer = ScCustomer;
        }
        public int GetCustomerId()
        {
            return customer.id;

        }
        public ShoppingCartItem GetProductById(int id)
        {
            var foundId =
                from e in products
                where e.product.id == id
                select e;
            if (foundId.Any())
            {
                return foundId.FirstOrDefault();
            }
            else
            {
                return null;
            }

        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            ShoppingCartItem cartItem = new ShoppingCartItem(prod, quantity);

            if (quantity < 1)
            {
                return null;
            }

            ShoppingCartItem shoppingCartItem = GetProductById(prod.id);

            if (shoppingCartItem != null)
            {

                shoppingCartItem.quantity = quantity + shoppingCartItem.quantity;
                return shoppingCartItem;
            }
            if (shoppingCartItem == null)
            {
                shoppingCartItem = cartItem;
                return cartItem;
            }


            return null;
        }
        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (quantity < 1)
            {
                return null;
            }

            ShoppingCartItem shoppingCartItem = GetProductById(prod.id);

            if (quantity > 0)
            {
                shoppingCartItem = null;
            }

            return shoppingCartItem;
        }

        public decimal GetTotal()
        {

            decimal total = 0;

            foreach (ShoppingCartItem shoppingCartItem in products)
            {
                total += shoppingCartItem.product.price * shoppingCartItem.quantity;
            }

            return total;
        }
        public List<ShoppingCartItem> GetProducts()
        {

            return products;
        }
    }
}
