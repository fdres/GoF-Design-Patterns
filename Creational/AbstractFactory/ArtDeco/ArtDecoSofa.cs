using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.ArtDeco
{
    // Concrete Products are created by corresponding Concrete Factories.
    internal class ArtDecoSofa : ISofa
    {
        public string SittingOnSofa()
        {
            return "Sitting on an art deco sofa";
        }
    }
}
