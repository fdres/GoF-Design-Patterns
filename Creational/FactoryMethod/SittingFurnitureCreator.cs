namespace FactoryMethod
{
    public abstract class SittingFurnitureCreator
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        protected abstract ISittingFurniture CreateSittingFurniture();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string SayMySittingFurniture()
        {
            var sittingFurniture = CreateSittingFurniture();
            return $"currently sitting {sittingFurniture.SittingOn()}";
        }
    }
}
