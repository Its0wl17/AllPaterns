using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most
{
    public abstract class Player //Abstraction
    {
        protected IWeapon _weapon;
        public IWeapon Weapon
        {
            set { _weapon = value; }
        }

        public Player(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public virtual void InfoAboutWeapon()
        {
            Console.WriteLine("Название: " + _weapon.Name());
            Console.WriteLine("ID: " + _weapon.Id());
            Console.WriteLine("Урон: " + _weapon.Damage());
            Console.WriteLine("Кол-во патрон в обойме: " + _weapon.Ammo());
        }

        public abstract void Buy();
    }
}