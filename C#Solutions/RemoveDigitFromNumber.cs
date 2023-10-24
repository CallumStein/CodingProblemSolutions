public class Solution {
    public string RemoveDigit(string number, char digit) {

        int index = -1;

        // Iterate through the number string
        for (int i = 0; i < number.Length; i++)
        {
            // If the value of the current digit matches the one to remove
            if (number[i] == digit)
            {
                // Store reference to the index
                index = i;
                
                // If the next digit is a higher value than the resulting number will likely be larger overall 
                if (i + 1 < number.Length && Char.GetNumericValue(number[i]) < Char.GetNumericValue(number[i+1]))
                {
                    // In this case break from the loop otherwise the last and lowest digit will be returned
                    break;
                }
            }
        }
        // Return the number string with the digit removed from the found index
        return number.Remove(index, 1);
    }
}