using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_1
{
    class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        // Constructor
        public Client(AbstractFactory factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductB.Print();
            abstractProductA = factory.CreateProductA();
            abstractProductA.Print();
        }

        public void Run()
        {
            abstractProductB.Interact(abstractProductA);
        }
    }
}
