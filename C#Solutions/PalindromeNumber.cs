public class Solution {
    public bool IsPalindrome(int x) {
    
        // Declare processing buffers to store the reversed input and working input
        int reversed = 0;
        int currentValue = x;

        // While the process buffer has not been reduced to zero, continue the reversal process
        while (currentValue > 0)
        {
            // Calculate the reversed value by adding the last digit of the current value, shifting by 10s each time
            reversed = reversed * 10 + currentValue % 10;
            // Remove the last digit of the process buffer by dividing by 10, discarding the remainder due to int format
            currentValue /= 10;
        }

        // When the processing has finished, return the boolean comparison of the reversed number to the input
        return reversed == x;
    }
}