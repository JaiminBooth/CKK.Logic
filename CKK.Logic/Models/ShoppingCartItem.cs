using System;
using CKK.Logic.Interfaces;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {


        public ShoppingCartItem(Product ShProduct, int ShQuantity)
        {
            Product = ShProduct;
            Quantity = ShQuantity;
        }


        public decimal GetTotal()
        {

            return Quantity * Product.Price;

        }
    }
}
