using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class Client
    {
        private CoffeeMachine _machine;

        public Client(CoffeeMachine machine)
        {
            _machine = machine;
        }

        public void AnOperation()
        {
            string coffee = _machine.Make();
            Console.WriteLine(coffee);
        }
    }
}
