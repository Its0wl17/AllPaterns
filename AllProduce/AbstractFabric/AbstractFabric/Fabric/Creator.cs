using System;
namespace AbstractFabric
{
    public abstract class Creator
    {
        public abstract Creator Clone();
        protected abstract ITable CreateTable();
        protected abstract ISofa CreateSofa();

        public string CreateTableFurniture()
        {
            var table = CreateTable();
            return table.TableStyle();
        }
        public string CreateSofaFurniture() 
        {
            var sofa = CreateSofa();
            return sofa.SofaStyle();
        }

    }
}