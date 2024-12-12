using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most
{
    public class RiflRound : Player //ModificateAbstraction
    {
        public RiflRound(IWeapon weapon)
        : base(weapon) { }

        public override void Buy()
        {
            Console.WriteLine("Покупка оружия: " + _weapon.Name());
        }
    }
}
