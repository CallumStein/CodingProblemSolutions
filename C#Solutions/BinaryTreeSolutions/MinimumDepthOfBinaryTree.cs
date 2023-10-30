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
    public int MinDepth(TreeNode root) {
        
        // Create a base case where if the end of any branch is reached, return 0
        if (root == null) { return 0; }

        // In the case where the left subtree is null, recursively find the minimum depth of the right branch
        if (root.left == null) { return 1 + MinDepth(root.right); }

        // In the case where the right subtree is null, recursively find the minimum depth of the left branch
        if (root.right == null) { return 1 + MinDepth(root.left); }

        // If both subtrees have nodes, recursively find the depth of each branch returning only the minimum path side
        return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
    }
}