using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_1
{
    class ConcreteFactory1:AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1("A1", 45, 24, 74); 
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1("B1", 58, 54, 7); 
        }
    }
}
