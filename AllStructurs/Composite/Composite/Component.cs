using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Component
    {
        protected string _name;

        public Component(string name) 
        {
            _name = name;
        }

        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }
        public virtual void DisplayInfo() 
        {
            Console.WriteLine(_name);
        }
    }
}
