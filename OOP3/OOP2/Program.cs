using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Scaner Epson = new Scaner("Epson", 125);
            Printer HP = new Printer("Hp", 85);
            CMFP Cannon = new CMFP("Cannon", 200);
            Memento Saver = new Memento();
            Restorer Rest = new Restorer();


            Saver.BackUp(HP);
            HP = HP + 30;

            Console.WriteLine(HP.ToString());
            HP = (Printer)Rest.Restor(Saver, HP);
            Console.WriteLine(HP.ToString());

            Cannon.WriteToFile();
            Cannon.WriteToAnotherFile();

            Purse.Money = 200;
            HP.buy();
            HP.sell();

            Console.WriteLine(Cannon.inf());

            var q = Singleton.MyInstance;
            Console.WriteLine(q.GetType());
        }
    }
}