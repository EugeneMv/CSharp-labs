using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP2
{
    class Printer : Product, DoWhat
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

        public Printer() : base("Printer", 75) { scan = false; print = true; }
        public Printer(string name) : base(name, 75) { scan = false; print = true; }
        public Printer(string name, float price) : base(name, price) { scan = false; print = true; }
        public Printer(string name, float price, int p) : base(name, price, p) { scan = false; print = true; }

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

        public override string ToString() => $"Printer {Name}   Scaning:{Scan}   Printing:{Print}   Price:{Price}";

        public override void WriteToFile()
        {
            File.WriteAllText("Printer.txt", "Model: " + Name);
            File.AppendAllText("Printer.txt", "\r\nScaning: " + Scan);
            File.AppendAllText("Printer.txt", "\r\nPrinting: " + Print);
            File.AppendAllText("Printer.txt", "\r\nPrice: " + Price);
        }

        public static Printer operator +(Printer p, float f)
        {
            checked
            {
                p.Price += f;
                return p;
            }
        }
        public static Printer operator -(Printer p, float f)
        {
            if (p.Price < f)
                throw new InvalidParameterException("that is impossible");
            else
            {
                p.Price -= f;
                return p;
            }
        }
        public static Printer operator *(Printer p, float f)
        {
            p.Price *= f;
            return p;
        }
        public static Printer operator /(Printer p, float f)
        {
            p.Price /= f;
            return p;
        }
        public static bool operator >(Printer p, Product p2)
        {
            return p.GetHashCode() > p2.GetHashCode();
        }
        public static bool operator <(Printer p, Product p2)
        {
            return p.GetHashCode() < p2.GetHashCode();
        }
        public static bool operator ==(Printer p, Product p2)
        {
            return p.GetHashCode() == p2.GetHashCode();
        }
        public static bool operator !=(Printer p, Product p2)
        {
            return p.GetHashCode() != p2.GetHashCode();
        }
    } 
}
