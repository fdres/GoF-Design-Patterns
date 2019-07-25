using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.Modern
{
    // Concrete Products are created by corresponding Concrete Factories.
    internal class ModernChair : IChair
    {
        public string SittingOnChair()
        {
            return "Sitting on a modern chair.";
        }
    }
}
