using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer customer;
        List<ShoppingCartItem> products;

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
            return customer.GetId();

        }
        public ShoppingCartItem GetProductById(int id)
        {
            var foundId =
                from e in products
                where e.GetProduct().GetId() == id
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

            ShoppingCartItem shoppingCartItem = GetProductById(prod.GetId());

            if (shoppingCartItem != null)
            {
                shoppingCartItem.SetQuantity(quantity + shoppingCartItem.GetQuantity());
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

            ShoppingCartItem shoppingCartItem = GetProductById(prod.GetId());

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
                total += shoppingCartItem.GetProduct().GetPrice() * shoppingCartItem.GetQuantity();
            }

            return total;
        }
        public List<ShoppingCartItem> GetProducts()
        {

            return products;
        }
    }
}
