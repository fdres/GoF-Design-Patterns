namespace FactoryMethod
{
    public class SofaCreator : SittingFurnitureCreator
    {
        protected override ISittingFurniture CreateSittingFurniture()
        {
            return new Sofa();
        }
    }
}
