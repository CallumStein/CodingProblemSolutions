public class Solution {
    public bool IsHappy(int n) {
        // Repeat the process for any double digit number    
        
        while(n > 9)
        {
            // Declare a new sum variable for each loop and continue the calculation until the number is 0 
            int sum = 0;
            while(n > 0)
            {
                // Calculate the square of the right most digit and add it the sum
                sum += (n % 10) * (n % 10);
                // Reduce the number by 1 digit
                n /= 10;
            }
            // After processing, swap the original value with the newly calculated sum and repeat the process
            n = sum;
        }

        // After all processing, the final value of n should be 1 or 7 to be an acceptable "Happy" number
        return n == 1 || n == 7 ;

        
    }
}