public class Solution {
    public uint reverseBits(uint n) {
        // Declare new unsigned int to store reversed number
        uint reversed = 0;

        // C# ints are 32 bits, iterate for each bit
        for (int i = 0; i < 32; i++)
        {
            // Move the most recent bit of the reverse number to the left
            reversed = reversed << 1;

            // If the right most bit of the original number is a 1 add it to the end of the reversed number
            if (n % 2 == 1) { reversed++; }

            // Shift the bit of the original number by 1 to the right
            n = n >> 1;
        }

        return reversed;
    }
}