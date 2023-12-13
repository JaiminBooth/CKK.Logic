using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic
{
    public class ShoppingCartItem : InventoryItem
    {


        public ShoppingCartItem(Product ShProduct, int ShQuantity)
        {
            product = ShProduct;
            quantity = ShQuantity;
        }


        public decimal GetTotal()
        {

            return quantity * product.price;

        }
    }
}
