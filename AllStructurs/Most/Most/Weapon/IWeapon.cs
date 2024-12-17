using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most
{
    public interface IWeapon //Realization
    {
        string Name();
        uint Id();
        double Damage();
        int Ammo();

    }
}
