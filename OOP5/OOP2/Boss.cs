using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public delegate void Delegat(int i);
    public delegate void Delegat2(int i, bool Active);

    class Boss
    {
        bool Active;

        public override int GetHashCode() => potential;

        public int potential;

        public event Delegat TurnOn;
        public event Delegat2 Upgrade;

        public void TurnOnActivate()
        {
            Active = true;
            if (TurnOn != null)
                TurnOn(potential);
        }

        public void UpgradeActivate(int Change)
        {
            potential += Change;
            Console.WriteLine("Potential is Changed");
            if (Upgrade != null)
                Upgrade(potential, Active);
        }
    }

  }
