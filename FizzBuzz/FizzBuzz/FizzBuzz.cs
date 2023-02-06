namespace Assignment1
{
    /// <summary>
    /// 1. Write a “fizzBuzz” method that accepts a number as input and returns it as a String
    /// 2. For multiples of three return “Fizz” instead of the number
    /// 3. For the multiples of five return “Buzz”
    /// 4. For numbers that are multiples of both three and five return “FizzBuzz”.
    /// 
    /// References
    /// TryParse: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
    /// </summary>
    public class FizzBuzz
    {   
        public string fizzBuzz(string input)
        {
            // Convert input to an integer
            if (int.TryParse(input, out int num))
            {
                // Check if num is a multiple of 3 and 5
                if ((num % 3 == 0 & num % 5 == 0))
                {
                    return "FizzBuzz";
                }
                // Check if num is a multiple of 3
                if ((num % 3 == 0))
                {
                    return "Fizz";
                }

                // Check if num is a multiple of 5
                if ((num % 5 == 0))
                {
                    return "Buzz";
                }
            }

            // Input cannot be converted to an integer
            return "Input is not a number";
        }
    }
}