public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        // Iterate through each number in the array
        for (int i = 0; i < nums.Length; i++)
        {
            
            // In the case where i can still be iterated 'k' times
            if (nums.Length > i + k)
            {
                // For each number, iterate 'k' places ahead
                for (int j = i + 1; j <= (i + k); j++)
                {
                    //Console.WriteLine("i: " + nums[i] + " j: " + nums[j]);
                    if (nums[i] == nums[j]) { return true; }
                }
            }
            else
            {
                // In the case where 'k' numbers can't be iterated, simply iterate to the end of the array
                for (int j = i + 1; j < nums.Length; j++)
                {
                    //Console.WriteLine("i: " + nums[i] + " j: " + nums[j]);
                    if (nums[i] == nums[j]) { return true; }
                }
            }
        }

        // If no duplicate is found after iteration return false
        return false;
    }
}