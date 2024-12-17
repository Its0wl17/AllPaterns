using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Client
    {
        static void Main()
        {
            CreateHouse house = new CreateHouse("Дом в стиле хайтек");
            CreateHouse cloneHouse = (CreateHouse) house.Clone();
            Console.WriteLine($"Основной дом: {house.Name}");

            Console.WriteLine($"\nСкопированный дом дом: {cloneHouse.Name}");
        }
    }
}
