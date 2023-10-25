/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        // Edge case to end recursion when there is no inputs left or the number of elements are zero
        if (nums == null || nums.Length == 0) { return null; }

        // Return the results of the subfunction with binary search starting parameters
        return ConvertArrayToTree(nums, 0, nums.Length - 1);
    }
    // Create a new function to perform a recursive binary search on the array creating new trees
    private TreeNode ConvertArrayToTree(int[] nums, int left, int right)
    {
        // Create a base case for recursion to end - when the left search margin is greater than the right
        if (left > right) { return null; }

        // Calculate the middle of the input array
        int middle = left + (right - left) / 2;

        // Create a new TreeNode storing the value of the middle index of the array
        TreeNode node = new TreeNode(nums[middle]);

        // Recursively call the function to determine the Left and Right sub trees for the current node
        node.left = ConvertArrayToTree(nums, left, middle - 1);
        node.right = ConvertArrayToTree(nums, middle + 1, right);

        // After all paths have been resolved return each node recursively as they were called
        return node;
    }
}