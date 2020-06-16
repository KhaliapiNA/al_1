using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract factory №1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client c1 = new Client(factory1);
            c1.Run();

            // Abstract factory №2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client c2 = new Client(factory2);
            c2.Run();


            Console.Read();
        }
    }
}
