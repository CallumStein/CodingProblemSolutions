public class Solution {
    public int RomanToInt(string s) {
        // Declare a lookup dictionary for Symbol/Value Comparison
        Dictionary<char, int> romanNumerals = new Dictionary<char, int>(){
                                {'I', 1},
                                {'V', 5},
                                {'X', 10},
                                {'L', 50},
                                {'C', 100},
                                {'D', 500},
                                {'M', 1000}
        };

        int output = 0;
        int currentDigit;

        // Iterate through the string adding the corresponding value of a symbol to output
        for (int i = 0; i < s.Length; i++)
        {
            // Store the value of the current Digit
            currentDigit = romanNumerals[s[i]];
            
            // Ensure that string index boundaries are in check
            if (i != s.Length-1)
            {
                // Read the following digit and check if it's value is higher than the current digit. Eg, IV
                if (romanNumerals[s[i]] < romanNumerals[s[i+1]])
                {
                    // Subtract the values to adjust (I,1)(V,5) -> (IV,4) and move the iterator by 1
                    currentDigit = romanNumerals[s[i+1]] - romanNumerals[s[i]];
                    i++;
                }
            }
            // Add the value to the output
            output += currentDigit;
        }
        // Return the output
        return output;
    }
}