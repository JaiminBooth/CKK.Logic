using System;
using System.Collections.Generic;
using System.Linq;
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
            
        }
        public void RemoveStoreItem(int productNumber)
        {

        }
        public Product GetStoreItem(int productNumber)
        {

        }
        public Product FindStoreItemByld(int id)
        {

        }
    }
}
