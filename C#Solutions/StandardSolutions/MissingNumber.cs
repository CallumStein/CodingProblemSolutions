public class Solution {
    
    // Faster approach of arithematic approach using Math.Sum() function
    public int MissingNumber(int[] nums) {
        // Calculate the difference between the expected sum of all numbers minus the actual sum
        int n = nums.Length;
        return (n * (n + 1) / 2) - nums.Sum();
    }

    // Approach using arithematic approach with conditionals
    public int MissingNumberArithematic(int[] nums) {
        // Calculate the expected sum of all numbers between 0 and n
        int n = nums.Length;
        int sum = n * (n + 1) / 2;

        // For each value in nums, subtract that value from the sum
        for(int i = 0; i < n; i++)
        {
            sum -= nums[i];
        }

        // The remaining value of sum is the missing value
        return sum;
    }

    // Approach using in-built Array sort function
    public int MissingNumberArray(int[] nums) {
        // Sort the input Array
        Array.Sort(nums);

        // Initialize a counter variable
        int count = 0;

        // Iterate through the nums array
        while (count < nums.Length)
        {
            // If the value doesn't match the count, return the count
            if (nums[count] != count) { return count; }

            // Iterate the counter
            count++;
        }

        // If the end of the sequence is reach return the counter
        return count;
    }

    // Far slower and more memory intensive approach using array comparison
    public int MissingNumberLINQ(int[] nums) {
        // Declare an array with a size of the available numbers
        int[] possibleValues = new int[nums.Length + 1];

        // Populate the possible values array
        for (int i = 0; i < possibleValues.Length; i++)
        {
            possibleValues[i] = i;
        }

        // Use C# LINQ function .Except() to find divergence of two arrays
        IEnumerable<int> test = possibleValues.Except(nums);

        // Return the single element of IEnumerable Collection
        return test.Single();
    }
}

