using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.ArtDeco
{
    // Concrete Products are created by corresponding Concrete Factories.
    internal class ArtDecoChair : IChair
    {
        public string SittingOnChair()
        {
            return "Sitting on an art deco chair.";
        }
    }
}
