using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most
{
    public class Glock_18 : IWeapon //ConcreteRealization
    {
        public string Name()
        {
            return "Glock_18";
        }

        public uint Id()
        {
            return 17641873;
        }

        public double Damage()
        {
            return 25;
        }
        
        public int Ammo()
        {
            return 30;
        }
    }
}
