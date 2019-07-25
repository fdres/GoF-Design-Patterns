using System;
using Prototype;
using Xunit;
using Xunit.Abstractions;

namespace TestCreationalPatterns
{
    public class PrototypeTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public PrototypeTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        [Trait("Creational", "Creational Patterns")]
        public void Test()
        {
            var p1 = new Person
            {
                Age = 42,
                BirthDate = Convert.ToDateTime("1977-01-01"),
                Name = "Jack Daniels",
                IdInfo = new IdInfo(12345)
            };

            // Perform a shallow copy of p1 and assign it to p2.
            var p2 = p1.ShallowCopy();
            // Make a deep copy of p1 and assign it to p3.
            var p3 = p1.DeepCopy();

            // Display values of p1, p2 and p3.
            _testOutputHelper.WriteLine("Original values of p1, p2, p3:");
            _testOutputHelper.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            _testOutputHelper.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            _testOutputHelper.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // Change the value of p1 properties and display the values of p1,
            // p2 and p3.
            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            _testOutputHelper.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            _testOutputHelper.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            _testOutputHelper.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            _testOutputHelper.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);
        }

        private void DisplayValues(Person p)
        {
            _testOutputHelper.WriteLine($"      Name: {p.Name}, Age: {p.Age}, BirthDate: {p.BirthDate}");
            _testOutputHelper.WriteLine($"      ID#: {p.IdInfo.IdNumber}");
        }
    }
}
