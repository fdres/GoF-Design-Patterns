using Builder;
using Xunit;
using Xunit.Abstractions;

namespace TestCreationalPatterns
{
    public class BuilderTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public BuilderTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        [Trait("Creational", "Creational Patterns")]
        public void Test()
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new BuildingHouseDirector();
            var builder = new HouseBuilder();
            director.Builder = builder;

            _testOutputHelper.WriteLine("Standard basic product:");
            director.BuildSimpleHouse();
            _testOutputHelper.WriteLine(builder.BuildHouse().ListParts());
            _testOutputHelper.WriteLine("");

            _testOutputHelper.WriteLine("Standard full featured product:");
            director.BuildFullHouse();
            _testOutputHelper.WriteLine(builder.BuildHouse().ListParts());
            _testOutputHelper.WriteLine("");

            // Remember, the Builder pattern can be used without a Director
            // class.
            _testOutputHelper.WriteLine("Custom product:");
            builder.BuildWalls();
            builder.InstallDoor();
            _testOutputHelper.WriteLine(builder.BuildHouse().ListParts());
        }
    }
}
