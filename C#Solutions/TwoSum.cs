public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Declare a new processing Dictionary to store values and indices
        Dictionary<int, int> map = new Dictionary<int, int>();

        // Iterate through the nums array calculating the complement of the current index to the target value
        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the Complement based on the target value
            int complement = target - nums[i];

            // Check if the complement already exists within the processing Dictionary
            if (map.ContainsKey(complement))
            {
                // Return the complements index and current value's index
                int[] output = {map[complement], i};
                return output;
            }
            // If the complement value does not exist yet, store the current value and index within the dictionary
            map[nums[i]] = i;
        }
        
        // In case there is no values that match the target return an empty array to ensure there is a possible exit path
        return new int[0];
    }
}