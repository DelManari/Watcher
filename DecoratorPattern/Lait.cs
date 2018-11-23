using System;

namespace DecoratorPattern
{
    internal class Lait : Decorator
    {
        public override void Operation()
        {
            base.Operation();

            Console.Write(" avec Lait");

        }
    }
}