using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.Modern
{
    // Concrete Products are created by corresponding Concrete Factories.
    internal class ModernSofa : ISofa
    {
        public string SittingOnSofa()
        {
            return "Sitting on a modern sofa";
        }
    }
}
