using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_1
{
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2("A2", 4, 45, 24);
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2("B2", 46, 12, 42); 
        }
    }
}