using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most
{
    public class Client //Just a programm
    {
        static void Main()
        {
            Player player1 = new PistolRound(new Glock_18());
            player1.InfoAboutWeapon();
            player1.Buy();
            Console.WriteLine("\n\n");
            Player player2 = new RiflRound(new AK_47());
            player2.InfoAboutWeapon();
            player2.Buy();
            Console.ReadLine();
        }
    }
}
