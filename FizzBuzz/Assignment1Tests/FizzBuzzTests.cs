using Assignment1;
using System.Reflection.Metadata;

namespace Assignment1Tests
{
    public class fizzBuzzTests
    {
        private fizzBuzz _fizzBuzz { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _fizzBuzz= new fizzBuzz();
        }

        // Test if the input in a number
        [Test]
        public void Is_Input_Int()
        {
            // Assign

            // Act

            // Assert


            Assert.Pass();
        }
    }
}