using System;
using System.Collections.Generic;
using System.Linq;

using System.Security.Cryptography.X509Certificates;

using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int id;
        private string name;
        List<StoreItem> items;




        public Store()
        {
            items = new List<StoreItem>();

        }
        public int GetId()
        {
            return id;
        }
        public void SetId(int StId)
        {
            id = StId;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string StName)
        {
            name = StName;
        }
        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (quantity <= 0)
            {
                return null;
            }

            StoreItem storeItem = FindStoreItemById(prod.GetId());

            if (storeItem != null)
            {
                storeItem.SetQuantity(storeItem.GetQuantity() + quantity);
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
    }
}
