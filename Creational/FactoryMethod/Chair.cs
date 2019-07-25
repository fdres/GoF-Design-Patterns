namespace FactoryMethod
{
    internal class Chair : ISittingFurniture
    {
        public string SittingOn()
        {
            return "on a chair";
        }
    }
}
