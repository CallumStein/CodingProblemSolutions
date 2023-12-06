public class Solution {
    public int[] PlusOne(int[] digits) {
        
        // Determine the length of the array and iterate through in descending order
        int n = digits.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            // If the current digit is less than 9
            if (digits[i] < 9)
            {
                // Increment the current digit and return the array
                digits[i]++;
                return digits;
            }
            // If the digit was 9, set the digit to 0 and move to the next digit
            digits[i] = 0;
        }
            // In the case that all digits were 9, create a new array that is 1 digit longer than the original number
            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;
            // Return the new array instead
            return newNumber;
    }
}