﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product
    {
        private int id;
        private string name;
        private decimal price;


        public int GetId()
        {
            return id;
        }

        public void SetId(int PId)
        {
            id = PId;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string PName)
        {
            name = PName;
        }
        public decimal GetPrice()
        {
            return price;
        }
        public void SetPrice(decimal PPrice)
        {
            price = PPrice;
        }
    }
}
