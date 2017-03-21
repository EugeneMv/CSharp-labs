using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
   static class Purse
    {
        static float money;

        public static float Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value >= 0)
                    money = value;
                else
                    throw new InvalidParameterException("wrong format of money");
            }
        }

    }
}
