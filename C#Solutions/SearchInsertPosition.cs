public class Solution {
    public int SearchInsert(int[] nums, int target, int scaler = 0) {
        // Find the location of the target in the array
        int placementIndex = Array.IndexOf(nums, target);

        // If the target is lower than the lowest value of the array
        if (target < nums[0])
        {
            // Return zero index
            return 0;
        }
        // If the target is greater than the highest value of the array
        if (target > nums[nums.Length-1])
        {
            // Return the last index
            return nums.Length;
        }
        
        // If the target was not found, recursively call the function checking for the next lowest value
        if (placementIndex == -1)
        {
            // Increase the adjustment scaler to 1
            return SearchInsert(nums, target-1, 1);
        }

        // return the index with a index adjustment scaler to move it forward one place if target wasn't found
        return placementIndex + scaler; 
    }
}