using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most
{
    public class AK_47 : IWeapon //ConcreteRealization
    {
        public string Name()
        {
            return "AK_47";
        }

        public uint Id()
        {
            return 1654362;
        }

        public double Damage()
        {
            return 40;
        }
        
        public int Ammo()
        {
            return 30;
        }
    }
}
