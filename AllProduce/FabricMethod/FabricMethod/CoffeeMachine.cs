using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public abstract class CoffeeMachine
    {
        public string Make() 
        {
            Console.Write("Готовится кофе: ");
            var coffee1 = MakeCoffee();

            return coffee1.Coffee();
        }
        public abstract ICoffee MakeCoffee();

    }
}
