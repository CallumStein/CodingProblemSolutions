public class Solution {
    public int SingleNumber(int[] nums) {
        // Sort the array for easier processing
        Array.Sort(nums);

        // iterate through the array in pairs of 2
        for (int i = 0; i < nums.Length - 1; i = i + 2)
        {
            // If two values of the pairs don't match return the first value
            if (nums[i] != nums[i+1]) { return nums[i]; }
        }

        // If the end of the array is reached and no pair mismatch is found, return the last index
        return nums[nums.Length-1];
    }
}