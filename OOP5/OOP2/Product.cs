using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{

    abstract class Product
    {
        bool working;
        float price; string name; // просто ячейки хранения
        public bool isWork
        {
            set { if (!isBreak) working = value; }
            get { return working;  }
        }
        public bool isBreak;
        int MaxPotential;

        public string Inf() => $"Name {Name}, Work {isWork}, Break {isBreak}";

        public void OnTurnOn(int i)
        {
                if (i < MaxPotential) {
                isWork = true;
                Console.WriteLine(Inf());
            }
            else
            {
                isBreak = true;
                isWork = false;
                Console.WriteLine(Inf());
            }
        }
        public void OnUpgraded(int i, bool b)
        {
            if (b)
            {
                if (i < MaxPotential)
                {
                    isWork = true;
                }
                else
                {
                    isBreak = true;
                    isWork = false;
                    Console.WriteLine(Inf());
                }
            }
            
        }


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

        protected Product() { Name = "none";  Price = 0; MaxPotential = 220; }
        protected Product(string name) { Name = name; Price = 0; MaxPotential = 220; }
        protected Product(string name, float price) { Name = name; Price = price; MaxPotential = 220; }
        protected Product(string name, float price, int pot) { Name = name; Price = price; MaxPotential = pot; }

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
