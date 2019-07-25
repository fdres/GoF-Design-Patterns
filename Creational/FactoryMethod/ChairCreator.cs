namespace FactoryMethod
{
    public class ChairCreator : SittingFurnitureCreator
    {
        protected override ISittingFurniture CreateSittingFurniture()
        {
            return new Chair();
        }
    }
}
