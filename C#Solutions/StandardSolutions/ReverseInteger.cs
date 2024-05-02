public class Solution {
    public int Reverse(int x) {

        // Declare an output integer and decimal place counter
        int output = 0;

        while(x != 0)
        {
            // Arithematically obtain the last digit of the input integer
            int temp = x % 10;

            // Check if the output is still within the range conditions of a signed 32-bit integer
            // Int32 is 2 to the power of 32 bytes, as we are adding an additional digit to the value we divide max/min value by 10 as our boundary
            if( output < Int32.MinValue / 10 || output > Int32.MaxValue / 10) 
            {
                // If outside of the range we return 0
                return 0; 
            }

            // Add the last integer to the output and shift by a decimal place each loop
            output = output * 10 + temp;

            // Reduce the input by 1 decimal place
            x /= 10;
            
        }

        // After processing return the output
        return output;
    }
}