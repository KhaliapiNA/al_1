using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_1
{
    class ProductB2:AbstractProductB
    {
        public ProductB2(string naz, double mas, double ugl_s, double ugl_u)
        {
            n = naz;
            m = mas;
            us = ugl_s;
            uus = ugl_u;
        }
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this + " vzaimodeistvuet s " + a);
        }
    }
}