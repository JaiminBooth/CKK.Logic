using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
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
            if (id < 0)
            {
                throw new InvalidIdException();
            }
            if (products != null)
            {
                var foundId =
                    from e in products
                    where e.Product.id == id
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

            if (quantity <= 0)
            {
                throw new InventoryItemStockTooLowException();
            }



            if (cartItem != null)
            {

                cartItem.Quantity = quantity + cartItem.Quantity;
                return cartItem;
            }
            if (cartItem == null)
            {
                ShoppingCartItem shoppingCartItem = new ShoppingCartItem(prod, quantity);
                products.Add(shoppingCartItem);

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
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (products.Contains(cartItem))
            {
                return null;
            }
            else
            {
                throw new ProductDoesNotExistException();
            }

            if (quantity > 0)
            {
                cartItem.Quantity = quantity - cartItem.Quantity;
            }

            return cartItem;
        }

        public decimal GetTotal()
        {

            decimal total = 0;

            foreach (ShoppingCartItem shoppingCartItem in products)
            {
                total += shoppingCartItem.Product.price * shoppingCartItem.Quantity;
            }

            return total;
        }
        public List<ShoppingCartItem> GetProducts()
        {

            return products;
        }
    }
}
