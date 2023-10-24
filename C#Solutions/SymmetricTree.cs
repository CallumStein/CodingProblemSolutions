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
    public bool IsSymmetric(TreeNode root) {
        return IsMirror(root, root);
    }

    // Auxilliary Function to recursively compare two nodes
    public bool IsMirror(TreeNode leftRoot, TreeNode rightRoot) {

        // If both trees are empty then they are automatically symmetric
        if (leftRoot == null && rightRoot == null)
        {
            return true;
        }

        // Perform a check of the two passed nodes, if their values match eachother and both nodes exist
        if (leftRoot != null && rightRoot != null && leftRoot.val == rightRoot.val)
        {
            // Recursively call the function twice to compare the reflections of left and right subtree nodes
            return IsMirror(leftRoot.left, rightRoot.right) && IsMirror(leftRoot.right, rightRoot.left);
        }

        // If these conditions above are not met for any of the nodes of the tree, it is not symmetrical
        return false;
       
    }
}