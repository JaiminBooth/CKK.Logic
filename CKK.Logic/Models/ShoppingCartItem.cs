using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product product;
        private int quantity;

        public ShoppingCartItem(Product ShProduct, int ShQuantity)
        {
            product = ShProduct;
            quantity = ShQuantity;
        }
        public Product GetProduct()
        {
            return product;
        }
        public void SetProduct(Product ShProduct)
        {
            product = ShProduct;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetQuantity(int ShQuantity)
        {
            quantity = ShQuantity;
        }
        public decimal GetTotal()
        {
            return quantity * PPrice;
        }
    }
}
