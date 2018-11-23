using System;

namespace DecoratorPattern
{
    internal class Chocolat : Decorator
    {
        public override void Operation()
        {
            base.Operation();

            Console.Write(" avec Chocolate");

        }
    }
}