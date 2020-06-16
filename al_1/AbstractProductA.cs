using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_1
{
   abstract class AbstractProductA
    {
        protected string n;
        protected double m;
        protected double s;
        protected double u;

        public void Print()
        {
            Console.WriteLine("Nazvanie {0} Massa {1} Skorost {2} Uskorenie {3}", n, m, s, u);
        }
    }
}
