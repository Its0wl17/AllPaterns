using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class DeathStar : Component
    {
        List<Component> components = new List<Component>();

        public DeathStar(string name) 
            : base(name) { }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\nНаименование: " + _name);
            Console.WriteLine("Состав: ");
           for(int i = 0; i < components.Count; i++)
            {
                components[i].DisplayInfo();
            }
        }
    }
}
