using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public sealed class Singleton
    {
        static readonly Singleton myInstance =
           new Singleton();

        static Singleton() { }

        Singleton() { }

        public static Singleton MyInstance
        {
            get
            {
                return myInstance;
            }
        }
    }
}
