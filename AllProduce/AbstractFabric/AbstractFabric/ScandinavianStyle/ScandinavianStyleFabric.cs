using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class ScandinavianStyleFabric : Creator
    {
        private static ScandinavianStyleFabric _instance;

        private ScandinavianStyleFabric() { }

        public static ScandinavianStyleFabric Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ScandinavianStyleFabric();
                }
                return _instance;
            }
        }

        public override Creator Clone()
        {
            return new ScandinavianStyleFabric();
        }

        protected override ISofa CreateSofa()
        {
            return new SSofa();
        }

        protected override ITable CreateTable()
        {
            return new STable();
        }
    }
}
