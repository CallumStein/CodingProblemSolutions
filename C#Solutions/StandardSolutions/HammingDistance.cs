public class Solution {
    public int HammingDistance(int x, int y) {
        // Store a value to count the distance
        int distCount = 0;

        // Use XOR operator to compare x and y - XOR returns true if inputs are different eg. TRUE ^ FALSE -> TRUE
        // In this case, the ^ operators sets to 1 only the bits that are different between both integers
        for (int dist = x ^ y; dist > 0; ++distCount)
        {
            // We then count the bit set to 1 using the Peter Wegner way
            // for example: 
            // Iteration 1 - 5 (0101)
            // Iteration 2 - 4 (0100)
            // Iteration 3 - 0 (0000)
            dist = dist & (dist - 1); // Setting to zero val's lowest-order 1
        }

    // Return the number of differing bits
    return distCount;
    }
}