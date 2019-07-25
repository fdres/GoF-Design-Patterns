using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.Victorian
{
    internal class VictorianChair : IChair
    {
        public string SittingOnChair()
        {
            return "Sitting on a victorian chair.";
        }
    }
}
