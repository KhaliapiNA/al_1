using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_1
{
   abstract class AbstractProductB
    {
       protected string n;
        protected double m;
        protected double us;
        protected double uus;

        public void Print()
        {
            Console.WriteLine("Nazvanie {0} Massa {1} Ugl_skorost {2} Ugl_Uskorenie {3}", n, m, us, uus);
        }
        public abstract void Interact(AbstractProductA a);
    }
    }

