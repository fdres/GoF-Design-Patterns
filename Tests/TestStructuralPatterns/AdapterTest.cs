using Adapter;
using Xunit;
using Xunit.Abstractions;

namespace TestStructuralPatterns
{
    public class AdapterTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public AdapterTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        [Trait("Structural", "Structural Patterns")]
        public void Test()
        {
            var adaptee = new Adaptee();
            ITarget target = new Adapter.Adapter(adaptee);

            _testOutputHelper.WriteLine("Adaptee interface is incompatible with the client.");
            _testOutputHelper.WriteLine("But with adapter client can call it's method.");

            _testOutputHelper.WriteLine(target.GetRequest());
        }
    }
}
