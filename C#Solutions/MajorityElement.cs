public class Solution {
    public int MajorityElement(int[] nums) {
        // Declare a Dictionary to store number and counts
        Dictionary<int, int> numbers = new Dictionary<int, int>(); 

        // Iterate through the numbers array
        for (int i = 0; i < nums.Length; i++)
        {
            // If the current number is already in the dictionary increase its count by 1           
            if (numbers.ContainsKey(nums[i])) { numbers[nums[i]] += 1; }
            // Otherwise add the number to the Dictionary and set its count to 1
            else { numbers.Add(nums[i], 1); }

            // Break the loop when any particular number has a count greater than (n / 2) + 1
            if (numbers.ContainsValue((nums.Length/2) + 1)) { return nums[i]; }
        }
        // Emergency return case for invalid input arrays
        return 0;
    }
}