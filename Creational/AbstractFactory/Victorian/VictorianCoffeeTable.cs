using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.Victorian
{
    internal class VictorianCoffeeTable : ICoffeeTable
    {
        public string UseTable()
        {
            return "Placing coffee on a victorian table";
        }
    }
}
