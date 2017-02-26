using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{

    abstract class Product
    {
        float price; string name; // просто ячейки хранения

        public float Price { get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new InvalidParameterException("wrong format of price");
            }
        }
        public string Name { get; set; }
        public bool isMine;

        protected Product() { Name = "none";  Price = 0; }
        protected Product(string name) { Name = name; Price = 0; }
        protected Product(string name, float price) { Name = name; Price = price; }

        public abstract void WriteToFile();

    }

    class InvalidParameterException : Exception
    {
        private string message;

        public InvalidParameterException(string message)
        {
            this.message = message;
        }

        public string What()
        {
            return message;
        }
    }
}
