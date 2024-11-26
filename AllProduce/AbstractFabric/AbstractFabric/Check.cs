using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    public class Check
    {
        static void Main()
        {
            Creator modern = ModernStyleFabric.Instance;
            Client client1 = new Client(modern);

            client1.AnOperation();

            Console.WriteLine("\n");

            Creator scandinavian = ScandinavianStyleFabric.Instance;
            Client client2 = new Client(scandinavian);

            client2.AnOperation();

            Console.WriteLine("\n");

            ModernStyleFabric cloneModern = (ModernStyleFabric)modern.Clone();
            Client client3 = new Client(cloneModern);

            client3.AnOperation();

            Console.ReadLine();
        }
    }
}
