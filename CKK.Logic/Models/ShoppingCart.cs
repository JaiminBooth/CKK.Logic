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
        private ShoppingCartItem product1;
        private ShoppingCartItem product2;
        private ShoppingCartItem product3;

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
            if (id == product1.GetProduct().GetId())
            {
                return product1;
            }
            else if (id == product2.GetProduct().GetId())
            {
                return product2;
            }
            else if (id == product3.GetProduct().GetId())
            {
                return product3;
            }
            return null;
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            ShoppingCartItem CartItem = new ShoppingCartItem(prod, quantity);

            if (quantity < 0)
            {
                return null;
            }
            if (product1 != null)
            {
                product1.SetQuantity(quantity + product1.GetQuantity());
            }
            if (product2 != null)
            {
                product2.SetQuantity(quantity + product2.GetQuantity());
            }
            if (product3 != null)
            {
                product3.SetQuantity(quantity + product3.GetQuantity());
            }
            if (product1 == null)
            {
                return CartItem;
            }
            if (product2 == null)
            {
                return CartItem;
            }
            if (product3 == null)
            {
                return CartItem;
            }
            return null;
        }
        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (quantity < 0)
            {
                return null;
            }
            if (product1 != null)
            {
                product1.SetQuantity(quantity - product1.GetQuantity());
            }
            if (product2 != null)
            {
                product2.SetQuantity(quantity - product2.GetQuantity());
            }
            if (product3 != null)
            {
                product3.SetQuantity(quantity - product3.GetQuantity());
            }

            return null;
        }

        public decimal GetTotal()
        {
            return product1.GetTotal() + product2.GetTotal() + product3.GetTotal();
        }
        public ShoppingCartItem GetProduct(int prodNum)
        {
            if (prodNum == 1)
            {
                return product1;
            }
            else if (prodNum == 2)
            {
                return product2;
            }
            else if (prodNum == 3)
            {
                return product3;
            }
            return null;
        }
    }
}
