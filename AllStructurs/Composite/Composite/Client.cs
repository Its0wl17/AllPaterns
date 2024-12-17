using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Client
    {
        static void Main()
        {
            Component hangar = new DeathStar("Hangar<A>");
            Component shuttle = new DeathStar("Shuttle1");
            Component captain = new Crew("Captain John");
            Component clonArmy1 = new Crew("CloneArmyFirstDivision");
            Component clonArmy2 = new Crew("CloneArmySecondDivision");

            shuttle.Add(captain);
            shuttle.Add(clonArmy1);
            shuttle.Add(clonArmy2);
            hangar.Add(shuttle);
            shuttle.DisplayInfo();
            Console.WriteLine("\n\n");

            hangar.DisplayInfo();
        }
    }
}
