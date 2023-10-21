public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // Largest index position would be the product of m + n adjusted for zero index
        int index = m-- + n-- - 1;

        // While there are still values in nums2 that haven't been sorted
        while (n >= 0)
        {

            // Compare the highest value in nums1 to nums2 while also that nums1 hasn't ran out of numbers
            if (m >= 0 && nums1[m] > nums2[n])
            {
                // Place the value of nums1 into the final position and shift nums1 position
                nums1[index] = nums1[m];
                m--;
            }
            // Else if nums2 largest value is higer
            else
            {
                // Place the value of nums2 into the final position and shift nums2 position
                nums1[index] = nums2[n];
                n--;
            }

            // Move the placement index to the next lowest position
            index--;
        }
        
    }
}