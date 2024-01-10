using System;
using CKK.Logic.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {
        private decimal Price;
        public decimal price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                Price = value;
            }
        }




    }
}
