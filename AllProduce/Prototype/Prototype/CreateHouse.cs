using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class CreateHouse : Prototype, IHouse
    {
        public string Name { get; }

        public CreateHouse(string name)
        {
            Name = name;
        }

        public Prototype Clone()
        {
            return new CreateHouse(Name);
        }
    }
}
