using Singleton;
using Xunit;
using Xunit.Abstractions;

namespace TestCreationalPatterns
{
    public class SingletonTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public SingletonTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        [Trait("Creational", "Creational Patterns")]
        public void Test()
        {
            // The client code.
            var s1 = SingletonObject.GetInstance();
            var s2 = SingletonObject.GetInstance();

            _testOutputHelper.WriteLine(s1 == s2
                ? "Singleton works, both variables contain the same instance."
                : "Singleton failed, variables contain different instances.");
        }
    }
}
