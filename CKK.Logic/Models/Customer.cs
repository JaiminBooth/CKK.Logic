using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer
    {
        private int id;
        private string name;
        private string address;
        
        public int GetId()
        {
            return id;
        }
        public void SetId(int CId)
        {
            id = CId;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string CName)
        {
            name = CName;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string CAddress)
        {
            address = CAddress;
        }
    }
}
