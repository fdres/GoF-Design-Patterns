using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.Modern
{
    internal class ModernCoffeeTable : ICoffeeTable
    {
        public string UseTable()
        {
            return "Placing coffee on a modern table";
        }
    }
}
