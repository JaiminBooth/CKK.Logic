using System;
using CKK.Logic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    public abstract class Entity
    {
        private int Id;
        public int id
        {
            get
            {
                return Id;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidIdException();

                }
                Id = value;
            }
        }
        public string name { get; set; }
    }
}