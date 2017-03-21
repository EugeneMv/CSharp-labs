using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Memento
    {
        public float PriceOld { get; private set; }
        public Product Prod { get; set; }

        public void BackUp(Product p)
        {
            PriceOld = p.Price;
            Prod = p;
        }

        public Memento() { }
    }

    class Restorer
    {
        public Product Restor(Memento m, Product p)
        {
            if (m.Prod.Equals(p))
            {
                p.Price = m.PriceOld;
                return p;
            }
            else
                return null;
        }
    }
}
