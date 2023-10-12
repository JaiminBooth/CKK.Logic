using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic
{
    public class Customer
    {
        public int id;
        public string name;
        public string address;
        public Customer(int CId, string CName, string CAddress)
        {
            id = CId;
            name = CName;
            address = CAddress;
        }
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
