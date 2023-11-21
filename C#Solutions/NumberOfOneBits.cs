public class Solution {
    public int HammingWeight(uint n) {
        // Declare a variable to store the count of '1' bits
        int count = 0;

        // C# ints have 32 bits, loop through each bit
        for (int i = 0; i < 32; i++)
        {
            // If the current bit after modulating by 2 is 1 increase the count
            if (n % 2 == 1) { count++; }

            // Shift the bits of the number by 1 to the right This effectively removes the last digit
            n = n >> 1;
        }
        // Return the count after processing
        return count;
    }
}