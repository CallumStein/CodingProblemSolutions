public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        // Edge case for single element arrays
        if (nums.Length == 1) { return false; }

        // Declare a HashSet to store unique values of nums
        HashSet<int> uniqueNums = new HashSet<int>();

        // Establish two pointers for the start and end of the array
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right)
        {
            // Check if the current values are already in the Hash Set
            if (uniqueNums.Contains(nums[left]) || uniqueNums.Contains(nums[right]))
            {
                // If duplicates have been found return true
                return true;
            }
            // Else add those values to the hashset
            else
            {
                uniqueNums.Add(nums[left]);
                uniqueNums.Add(nums[right]);
            }

            // Iterate the pointers
            left++;
            right--;
        }

        // perform a final check to test the length of the set to the original array
        if (uniqueNums.Count != nums.Length) { return true; }

        // If no duplicates are found return false
        return false; 
        
    }
}