using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class Test
    {
        static void Main()
        {
            CoffeeMachine latte = new CreateLatte();
            Client client = new Client(latte);
            client.AnOperation();
            Console.WriteLine("\n");
            CoffeeMachine cappuccino = new CreateCappuccino();
            client = new Client(cappuccino);
            client.AnOperation();
            Console.ReadLine();
        }
    }
}
