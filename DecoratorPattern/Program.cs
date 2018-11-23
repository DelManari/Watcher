using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create ConcreteComponent and two Decorators

            Cofe c = new Cofe();

            Lait d1 = new Lait();

            Chocolat d2 = new Chocolat();


            d1.SetComponent(c);

            d2.SetComponent(d1);



            d2.Operation();

            Console.ReadKey();
        }
    }
}
