using Assignment1;

namespace Assignment1Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        /*
         * Test if passVal() returns a string
         * from a given number
         */
        [Test]
        public void fizzBuzz_Returns_String()
        {
            string num = "5";

            var fizz = _fizzBuzz.fizzBuzz(num);

            Assert.True(fizz is string);
        }

        /*
         * Test if a number is an integer
         */
        [TestCase("A")]
        [TestCase("This is a string")]
        public void FizzBuzz_Input_Is_Not_Integer(string num)
        {
            var fizz = _fizzBuzz.fizzBuzz(num);

            Assert.AreEqual("Input is not a number", fizz);
        }

        /*
         * Test if a number is a multiple of 3
         */
        [TestCase("3")]
        [TestCase("9")]
        [TestCase("36")]
        [TestCase("243")]
        public void fizzBuzz_Is_Multiple_Of_3(string num)
        {
            var fizz = _fizzBuzz.fizzBuzz(num);

            Assert.AreEqual("Fizz", fizz);
        }

        /*
         * Test if a number is a multiple of 5
         */
        [TestCase("5")]
        [TestCase("25")]
        [TestCase("125")]
        public void fizzBuzz_Is_Multiple_Of_5(string num)
        {
            var fizz = _fizzBuzz.fizzBuzz(num);

            Assert.AreEqual("Buzz", fizz);
        }

        /*
         * Test if a number is a multiple of 3 and 5
         */
        [TestCase("15")]
        [TestCase("60")]
        [TestCase("120")]
        public void fizzBuzz_Is_Multiple_Of_5_and_3(string num)
        {
            var fizz = _fizzBuzz.fizzBuzz(num);

            Assert.AreEqual("FizzBuzz", fizz);
        }
    }
}