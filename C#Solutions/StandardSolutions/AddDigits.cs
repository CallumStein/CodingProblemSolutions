public class Solution {
    public int AddDigits(int num) {
        // While the current value is greater than 10, 2 digits or more
        // Create an outer while loop to continuely process for each summing iteration
        while (num >= 10)
        {
            // Declare a new sum value to be used while processing
            int sum = 0;

            // while the value of num is greater than 10
            while (num >= 10)
            {
                // Add each digit of num together while removing the last digit each time
                sum += num % 10;
                num = num / 10;
            }
            // When only one digit is left add it to the sum
            sum += num;

            // Set the value of num to equal the calculated sum
            num = sum;
        }
        // Return the final product after processing
        return num;
    }
}