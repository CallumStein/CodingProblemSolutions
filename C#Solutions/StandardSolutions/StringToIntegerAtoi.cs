public class Solution {
    public int MyAtoi(string s) {
        // Clean the input string
        s = s.Trim();

        // Boundary case for empty string input
        if (s.Length == 0) { return 0; }

        // Create an empty output string for processing
        String numericString = String.Empty;

        // Check if there are any operator signs present at the start of the string
        if(s[0] == '-' || s[0] == '+')
        {
            numericString += s[0];
            s = s.Remove(0,1);
        }

        // For each character in the remaining string
        foreach (char c in s)
        {
            // Check for numeric characters (0-9), or a negative sign
            if (c >= '0' && c <= '9')
            {
                numericString = string.Concat(numericString, c);
            }
            else
            {
                // Break the sequence early if a non-arithematic character is read
                break;
            }
        }

        // Using the int32 method TryParse, parse the string into an integer stored in output
        if (Int32.TryParse(numericString, out int output))
        {
            return output;
        }

        // Else if it cannot be parsed into an int32 type, check if its an empty string and return 0
        if (numericString.Length == 0)
        {
            return 0;
        }

        // If the string is not empty, assume overflow and determine its sign
        if(numericString[0] == '-' && numericString.Length > 1)
        {
            return Int32.MinValue;
        }
        else if (numericString.Length > 1)
        {
            return Int32.MaxValue;
        }

        // If this is reached there was some unusual string that couldn't be processed
        return 0;
    }
}