public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        // Declare the unique counter/index tracker
        int k = 1;

        // Iterate through the array
        for (int i = 1; i < nums.Length; i++)
        {
            // If the current value is not the same as the previous value
            if (nums[i] != nums[i-1])
            {
                // Store the unique value at the unique index and increment k
                nums[k] = nums[i];
                k++;
            }
        }

        // Return the number of unique values
        return k;
    }
}