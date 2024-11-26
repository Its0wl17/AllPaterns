using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class ModernStyleFabric : Creator
    {
        private static ModernStyleFabric _instance;

        private ModernStyleFabric() { }

        public static ModernStyleFabric Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ModernStyleFabric();
                }
                return _instance;
            }
        }

        public override Creator Clone()
        {
            return new ModernStyleFabric();
        }

        protected override ISofa CreateSofa()
        {
            return new MSofa();
        }

        protected override ITable CreateTable()
        {
            return new MTable();
        }
    }
}
