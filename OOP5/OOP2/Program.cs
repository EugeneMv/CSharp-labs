using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Scaner Epson = new Scaner("Epson", 125, 220);
            Printer HP = new Printer("Hp", 85, 300);
            CMFP Cannon = new CMFP("Cannon", 200, 100);

            Boss Electric = new Boss();
            Electric.TurnOn += Epson.OnTurnOn;
            Electric.TurnOn += HP.OnTurnOn;
            Electric.TurnOn += Cannon.OnTurnOn;

            Electric.Upgrade += Epson.OnUpgraded;
            Electric.Upgrade += HP.OnUpgraded;
            Electric.Upgrade += Cannon.OnUpgraded;

            Console.WriteLine(Epson.Inf());
            Console.WriteLine(HP.Inf());
            Console.WriteLine(Cannon.Inf());
            Console.WriteLine();

            bool cycler = true;
            string ind;
            int Changer;
            while (cycler)
            {
                Console.WriteLine("1 - On the electric");
                Console.WriteLine("2 - Change potential");
                Console.WriteLine("3 - Potential on the screen");
                Console.WriteLine("4 - exit");

                ind = Console.ReadLine();

                switch (ind)
                {
                    case "1":
                        Electric.TurnOnActivate();
                        break;
                    case "2":
                        Console.WriteLine("How many?");
                        Changer = int.Parse(Console.ReadLine());
                        Electric.UpgradeActivate(Changer);
                        break;
                    case "3":
                        Console.WriteLine("Potential is " + Electric.potential);
                        break;
                    case "4":
                        cycler = false;
                        break;
                }
                Console.WriteLine();
            }
            Reflector Infer = new Reflector();
            Infer.InfFields(typeof(Product));
            Infer.InfInterfaces(typeof(Printer));
            Infer.InfMetods(typeof(Printer));
            Infer.InfClass(typeof(Printer));

        }
    }
}