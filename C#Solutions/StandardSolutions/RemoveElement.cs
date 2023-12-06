public class Solution {
    public int RemoveElement(int[] nums, int val) {
        // Initialize a counter variable for the unique number of elements removed
        int k = 0;

        // For each number in the array
        for (int i = 0; i < nums.Length; i++)
        {
            // If the number is not equal to the rejection value
            if (nums[i] != val) 
            {
                // Move the element to the front of the array and increment the unique counter
                nums[k] = nums[i];
                k++;
            }
        }

        // Return the number of the specified value removed
        return k;
    }
}