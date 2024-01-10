using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class StoreItem : InventoryItem
    {


        public StoreItem(Product SIProduct, int SIQuantity)
        {
            Product = SIProduct;
            Quantity = SIQuantity;
        }

    }
}