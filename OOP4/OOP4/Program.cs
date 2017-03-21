using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Product p1 = new Product("1", 1), p2 = new Product("2", 2), p3 = new Product("3", 3);

                CollectionType<Product> mylist = new CollectionType<Product>();

                mylist.Add(p3);
                mylist.Add(p2);
                mylist.Add(p1);

                foreach (Product p in mylist)
                    Console.WriteLine(p.ToString());

                Console.WriteLine("удалили p1");
                mylist.Remove(p1);

                foreach (Product p in mylist)
                    Console.WriteLine(p.ToString());

                int j;
                var mas = mylist.PriceEq(3, out j);
                for (int i = 0; i < j; i++)
                    Console.WriteLine(mas[i].ToString() + " поиск значений");

                Console.WriteLine(mylist.LastObjOf("<", 4) + " цена меньше 4");
                Console.WriteLine(mylist.LastObjOf(">", 0) + " цена больше 0");
                Console.WriteLine(mylist.LastObjOf("=", 1) + " цена равна 1");

                mylist.Sort();

                foreach (Product p in mylist)
                    Console.WriteLine(p.ToString());
            }
            catch(InvalidParameterException q)
            {
                Console.WriteLine(q.What());
            }
            finally
            {
                Console.WriteLine("End of program");
            }       
        }
    }
}
