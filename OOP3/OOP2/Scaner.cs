using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // работа с файлами

namespace OOP2
{
    class Scaner : Product, DoWhat
    {
        bool scan; bool print;

        public string Scan
        {
            get
            {
                if (scan)
                    return "yes";
                else
                    return "no";
            }
            protected set
            {
                // мне это не нужно
            }           
        }
        public string Print
        {
            get
            {
                if (print)
                    return "yes";
                else
                    return "no";
            }
            protected set
            {
                // мне это не нужно
            }
        }

        public Scaner() : base("Scaner", 100) { scan = true; print = false; }
        public Scaner(string name) : base(name, 100) { scan = true; print = false; }
        public Scaner(string name, float price) : base(name, price) { scan = true; print = false; }

        public void buy()
        {
            if (Price > Purse.Money)
                Console.WriteLine("You do not have enough money");
            else if (!isMine)
            {
                Purse.Money -= Price;
                isMine = true;
            }
            else
                Console.WriteLine("You got this already");
        }
        public void sell()
        {
            if (!isMine)
                Purse.Money += Price;
            else
                Console.WriteLine("It is not your thing");
        }

        public override void WriteToFile()
        {
            File.WriteAllText("Scaner.txt", "Model: " + Name);
            File.AppendAllText("Scaner.txt", "\r\nScaning: " + Scan);
            File.AppendAllText("Scaner.txt", "\r\nPrinting: " + Print);
            File.AppendAllText("Scaner.txt", "\r\nPrice: " + Price);
        }

        public override string ToString() => $"Scaner {Name}   Scaning:{Scan}   Printing:{Print}   Price:{Price}";

        public override bool Equals(object obj)
        {
            Console.WriteLine("Equals() is in proccessing");
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            Console.WriteLine("GetHashCode() is in proccessing");
            return base.GetHashCode();
        }
        
    }
}
