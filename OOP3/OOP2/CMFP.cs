using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace OOP2
{
    sealed partial class CMFP : Product, DoWhat
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

        public CMFP() : base("CMFP", 150) { scan = true; print = true; }
        public CMFP(string name) : base(name, 150) { scan = true; print = true; }
        public CMFP(string name, float price) : base(name, price) { scan = true; print = true; }

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

        public override string ToString() => $"CMFP {Name}   Scaning:{Scan}   Printing:{Print}   Price:{Price}";

        public override void WriteToFile()
        {
            File.WriteAllText("CMFP.txt", "Model: " + Name);
            File.AppendAllText("CMFP.txt", "\r\nPrice: " + Price);
        }

        public Tuple<string, float> inf()
        {
            return new Tuple<string, float>(Name, Price);
        }
    }

    partial class CMFP
    {
        public void WriteToAnotherFile()
        {
            File.WriteAllText("CMFP part2.txt", "\r\nScaning: " + Scan);
            File.AppendAllText("CMFP part2.txt", "\r\nPrinting: " + Print);
        }
    }
}
