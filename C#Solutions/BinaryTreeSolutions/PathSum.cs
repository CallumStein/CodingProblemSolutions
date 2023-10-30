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
    public bool HasPathSum(TreeNode root, int targetSum) {
        // If the end of the branch has been reached and target Sum has not been found return false to end search for that path
        if (root == null) { return false; }

        // If a Leaf Node has been reached in any path
        if (root.left == null && root.right == null) 
        { 
            // If that final leaf node's value will reach the target Sum return True
            if (targetSum - root.val == 0) { return true; }
        }

        // Recursively call the function for both subtrees of any given node reducing the target sum by that nodes value
        // In any situation where one of the traversal returns true, we know that a viable root-to-leaf path exists
        return (HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val));
    }
}