using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{

    class Product : IComparable
    {
        float price;// просто ячейки хранения

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

        public Product() { Name = "none";  Price = 0; }
        public Product(string name) { Name = name; Price = 0; }
        public Product(string name, float price) { Name = name; Price = price; }

        public override string ToString() => $"Name:{Name} Price:{Price}";

        public override int GetHashCode()
        {
            return (int)Price;
        }

        public int CompareTo(object obj)
        {
            if (GetHashCode() == obj.GetHashCode())
                return 0;
            else if (GetHashCode() >= obj.GetHashCode())
                return 1;
            else
                return -1;
        }

        // public void WriteToFile();

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
