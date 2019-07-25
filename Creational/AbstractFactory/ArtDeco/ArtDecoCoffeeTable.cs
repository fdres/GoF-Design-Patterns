using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.ArtDeco
{
    internal class ArtDecoCoffeeTable : ICoffeeTable
    {
        public string UseTable()
        {
            return "Placing coffee on an art deco table";
        }
    }
}
