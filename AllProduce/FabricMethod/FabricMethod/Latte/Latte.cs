using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class Latte : ICoffee
    {
        public string Coffee()
        {
            return $"Латте";
        }
    }
}
