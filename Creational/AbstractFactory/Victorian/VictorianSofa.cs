using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.Victorian
{
    internal class VictorianSofa : ISofa
    {
        public string SittingOnSofa()
        {
            return "Sitting on a victorian sofa";
        }
    }
}
