using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
        public class Client
        {
            private Creator _fabric;

            public Client(Creator fabric)
            {
                _fabric = fabric;
            }
            public void AnOperation()
            {
                string sofa = _fabric.CreateSofaFurniture();
                string table = _fabric.CreateTableFurniture();
            Console.WriteLine($"{sofa}\n{table}");
            }
        }
}
