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
    public int MaxDepth(TreeNode root) {
        // Define the base case for recursion
        if (root == null)
        {
            return 0;
        }

        // Recursively add 1 to each time the function is called 
        // tracking which side of the current node's subtree has a higher number of children
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right)); 
    }
}