namespace Assignment1
{
    /// <summary>
    /// Create a method that validates a user password
    /// 1. The password must be at least 8 characters long
    /// 2. The password must contain at least 2 numbers
    /// 3. Validation should handle multiple validation errors
    /// 4. The password must contain at least one capital letter
    /// 5. 5. The password must contain at least one special character
    /// </summary>

    public class PasswordValidation
    {
        // String of possible errors
        string errors = "";
        int numCount = 0, upperCount = 0;

        public string passVal(string input)
        {
            // Check password length
            if (input.Length < 8) 
            {
                // Append error message to string
                errors = errors + "Password must be at least 8 characters\n";
            }

            // Search for numbers and special characters
            foreach (char c in input) 
            {
                if (char.IsDigit(c) == true)
                {
                    numCount++;
                }

                if (char.IsUpper(c) == true)
                {
                    upperCount++;
                }
            }

            // Not enough numbers in password
            if (numCount < 2) 
            {
                errors = errors + "The password must contain at least 2 numbers\n";
            }

            // No capital characters in password
            if (upperCount == 0)
            {
                errors = errors + "password must contain at least one capital letter\n";
            }

            // Password passed validation
            if (errors == "") 
            {
                errors = "Password is Validated";
            }

            // Return string of errors
            return errors;
        }
    }
}