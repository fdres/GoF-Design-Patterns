using AbstractFactory.ArtDeco;
using AbstractFactory.FurnitureFactory;
using AbstractFactory.Modern;
using AbstractFactory.Victorian;
using Xunit;
using Xunit.Abstractions;

namespace TestCreationalPatterns
{
    public class AbstractFactoryTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public AbstractFactoryTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        [Trait("Creational", "Creational Patterns")]
        public void Test()
        {
            _testOutputHelper.WriteLine("Client: Testing client code with the Modern factory type...");
            ClientMethod(new ModernFurnitureFactory());

            _testOutputHelper.WriteLine("");

            _testOutputHelper.WriteLine("Client: Testing the same client code with the Victorian factory type...");
            ClientMethod(new VictorianFurnitureFactory());

            _testOutputHelper.WriteLine("");

            _testOutputHelper.WriteLine("Client: Testing the same client code with the ArtDeco factory type...");
            ClientMethod(new ArtDecoFurnitureFactory());
        }

        private void ClientMethod(IFurnitureFactory factory)
        {
            var chair = factory.CreateChair();
            _testOutputHelper.WriteLine(chair.SittingOnChair());

            var sofa = factory.CreateSofa();
            _testOutputHelper.WriteLine(sofa.SittingOnSofa());

            var coffeeTable = factory.CreateCoffeeTable();
            _testOutputHelper.WriteLine(coffeeTable.UseTable());
        }
    }
}
