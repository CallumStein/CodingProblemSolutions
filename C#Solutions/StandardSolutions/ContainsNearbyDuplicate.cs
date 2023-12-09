public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        // Utilize a Dictionary to store both the value and index of the elements in nums
        Dictionary<int, int> distinctValues = new Dictionary<int, int>();

        // Iterate through each value in nums
        for (int i = 0; i < nums.Length; i++)
        {
            // If the current value is not already stored in the dictionary, add it
            if (!distinctValues.ContainsKey(nums[i]))
            {
                distinctValues.Add(nums[i], i);
            }
            else
            {
                // Else if the value already exists, compare whether it is within k elements of the previously found value and return true
                if (Math.Abs(distinctValues[nums[i]] - i) <= k) { return true; }

                // If they are not within k elements, swap the stored index with the newly discovered value for further iterations
                distinctValues[nums[i]] = i;
            }
        }

        // If no duplicate is found after processing return false
        return false;
    }

    public bool ContainsNearbyDuplicateIterative(int[] nums, int k) {
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