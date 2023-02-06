using Assignment1;

namespace Assignment1Tests
{
    public class PasswordValidationTests
    {
        private PasswordValidation _password;

        [SetUp]
        public void Setup()
        {
            _password = new PasswordValidation();
        }

        /*
         * Test if a password is less than 8 characters long
         */
        [TestCase("A23")]
        [TestCase("teSt90")]
        [TestCase("123456K")]
        public void passVal_Less_Than_Length_8(string input)
        {
            var password = _password.passVal(input);

            Assert.AreEqual("Password must be at least 8 characters\n", password);
        }

        /*
         * Test if a password is less than 2 numbers
         */
        [TestCase("tHisisatest")]
        [TestCase("Thisisatest1")]
        public void passVal_Less_Than_2_Numbers(string input)
        {
            var password = _password.passVal(input);

            Assert.AreEqual("The password must contain at least 2 numbers\n", password);
        }

        /*
         * Test if a password has no capitalized characters
         */
        [TestCase("thisisatest22")]
        [TestCase("testwithnums345")]
        public void passVal_No_Capital_Characters(string input)
        {
            var password = _password.passVal(input);

            Assert.AreEqual("password must contain at least one capital letter\n", password);
        }


        /*
         * Test password for multiple Errors
         */
        [TestCase("test1")]
        public void passVal_Multiple_Errors(string input)
        {
            var password = _password.passVal(input);

            string errors = "Password must be at least 8 characters\n" +
                            "The password must contain at least 2 numbers\n" +
                            "password must contain at least one capital letter\n"; 

            Assert.AreEqual(errors, password);
        }
    }
}