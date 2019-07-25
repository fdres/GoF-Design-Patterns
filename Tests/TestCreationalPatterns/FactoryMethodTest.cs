using FactoryMethod;
using Xunit;
using Xunit.Abstractions;

namespace TestCreationalPatterns
{
    public class FactoryMethodTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public FactoryMethodTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        [Trait("Creational", "Creational Patterns")]
        public void Test()
        {
            _testOutputHelper.WriteLine("Offered the client a chair to sit on");
            ClientMethod(new ChairCreator());

            _testOutputHelper.WriteLine("");

            _testOutputHelper.WriteLine("Offered the same client a sofa to sit on");
            ClientMethod(new SofaCreator());
        }

        private void ClientMethod(SittingFurnitureCreator creator)
        {
            _testOutputHelper.WriteLine($"I am the client and I am {creator.SayMySittingFurniture()}");
        }
    }
}
