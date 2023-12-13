
using System;
using System.Collections.Generic;
using System.Linq;

using System.Security.Cryptography.X509Certificates;

using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic
{
    public class Store : Entity
    {

        public List<StoreItem> items;






        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (quantity <= 0)
            {
                return null;
            }

            StoreItem storeItem = FindStoreItemById(prod.id);

            if (storeItem != null)
            {

                storeItem.quantity = quantity + storeItem.quantity;
            }
            else
            {
                items.Add(storeItem);
            }

            return storeItem;
        }
        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            if (quantity <= 0)
            {
                return null;
            }

            StoreItem storeItem = FindStoreItemById(id);

            if (quantity > 0)
            {
                storeItem = null;
            }

            return storeItem;
        }
        public List<StoreItem> GetStoreItems(int productNum)
        {
            return items;
        }
        public StoreItem FindStoreItemById(int id)
        {
            var foundId =
                from e in items
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
    }
}
