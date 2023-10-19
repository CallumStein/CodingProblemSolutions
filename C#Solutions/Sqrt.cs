public class Solution {
    public int MySqrt(int x) {
        // Perform a binary search looking for the exponent of x

        // Declare start and end points for search - 0 to x
        int start = 0;
        int end = x;

        // While start and end are not equal
        while (start <= end)
        {
            // Must use a long as the square products become so large floats are no longer accurate
            // Calculate the middle value between the start and end
            long middle = (start + end)/2;
            // Calculate the square product
            long square = middle * middle;

            // Compare the square product to the value of x and adjust search points as necessary
            if (square == x) { return (int)middle; }
            else if (square > x) { end = (int)(middle - 1); }
            else { start = (int)(middle + 1); }
        }

        // In the case where the start and end have reached eachother, return the end
        // Start will be the root value ROUNDED UP
        // End will be the root value ROUNDED DOWN
        return end;
    }
}