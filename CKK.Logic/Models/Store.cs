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
        private Product product1;
        private Product product2;
        private Product product3;

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
        public void AddStoreItem(Product prod)
        {

            if (product1 == null)
            {
                product1 = prod;
            }
            else if (product2 == null)
            {
                product2 = prod;
            }
            else
            {
                product3 = prod;
            }
        }
        public void RemoveStoreItem(int productNum)
        {
            if (productNum == 1)
            {
                product1 = null;
            }
            else if (productNum == 2)
            {
                product2 = null;
            }
            else
            {
                product3 = null;
            }
        }
        public Product GetStoreItem(int productNum)
        {
            if (productNum == 1)
            {
                return product1;
            }
            else if (productNum == 2)
            {
                return product2;
            }
            else
            {
                return product3;
            }
        }
        public Product FindStoreItemById(int id)
        {
            if (product1 != null & product1.GetId() == id)
            {
                return product1;
            }
            else if (product2 != null & product2.GetId() == id)
            {
                return product2;
            }
            else if (product3 != null & product3.GetId() == id)
            {
                return product3;
            }
            else
            {
                return null;
            }
        }
    }
}
