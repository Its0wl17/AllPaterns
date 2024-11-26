using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class CreateCappuccino : CoffeeMachine
    {
        protected override ICoffee MakeCoffee()
        {
            return new Cappuccino();
        }
    }
}
