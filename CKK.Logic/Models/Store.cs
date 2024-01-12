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
    public class Store : Entity, IStore
    {

        public List<StoreItem> items;






        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (quantity <= 0)
            {
                throw new InventoryItemStockTooLowException();
            }

            StoreItem storeItem = FindStoreItemById(prod.Id);

            if (storeItem != null)
            {

                storeItem.Quantity = quantity + storeItem.Quantity;
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
                throw new ArgumentOutOfRangeException();
            }

            StoreItem storeItem = FindStoreItemById(id);

            if (items.Contains(storeItem))
            {
                return null;
            }
            else
            {
                throw new ProductDoesNotExistException();
            }


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
            if (id < 0)
            {
                throw new InvalidIdException();
            }
            var foundId =
                from e in items
                where e.Product.Id == id
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
