public class Solution {
    public int ClimbStairs(int n) {
        
        // Attempt 1 - Recursion TIMESOUT
        
        // Output testing shows Fibonacci Sequence
        // When the end of the sequence is reached
        //if (n <= 2) { return n; }
        // Otherwise return the product of n-1 + n-2
        //else { return ClimbStairs(n-1) + ClimbStairs(n-2); }

        // Attempt 2 - Native Approach

        // Define starting points
        int a = 0, b = 1, c = 0;

        // Iteratively count up to n while calculating the product of n-1 + n-2 with each step
        for(int i = 0; i < n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        
        // Return the final product once n steps are reached
        return c;
    }
}