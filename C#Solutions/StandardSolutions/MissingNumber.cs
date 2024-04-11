public class Solution {
    public int MissingNumber(int[] nums) {
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