using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic
{
    public class ShoppingCart : IShoppingCart
    {
        public Customer customer { get; set; }
        public List<ShoppingCartItem> products;


        public ShoppingCart(Customer ScCustomer)
        {
            customer = ScCustomer;
            products = new List<ShoppingCartItem>();
        }
        public int GetCustomerId()
        {
            return customer.id;

        }
        public ShoppingCartItem GetProductById(int id)
        {
            if (products != null)
            {
                var foundId =
                    from e in products
                    where e.product.id == id
                    select e;
                if (foundId.Any())
                {
                    return foundId.FirstOrDefault();
                }
            }


            return null;


        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            ShoppingCartItem cartItem = GetProductById(prod.id);

            if (quantity < 1)
            {
                return null;
            }

            //ShoppingCartItem shoppingCartItem = GetProductById(prod.id);

            if (cartItem != null)
            {

                cartItem.quantity = quantity + cartItem.quantity;
                return cartItem;
            }
            if (cartItem == null)
            {
                ShoppingCartItem shoppingCartItem = new ShoppingCartItem(prod, quantity);
                products.Add(shoppingCartItem);
                // shoppingCartItem = cartItem;
                return shoppingCartItem;
            }


            return null;
        }
        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            ShoppingCartItem cartItem = GetProductById(prod.id);
            if (quantity < 1)
            {
                return null;
            }



            if (quantity > 0)
            {
                cartItem.quantity = quantity - cartItem.quantity;
            }

            return cartItem;
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
