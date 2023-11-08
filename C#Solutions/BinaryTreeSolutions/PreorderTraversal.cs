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
    // Public attribute to store tree traversal
    List<int> PreOrderTreeValues = new List<int>();

    public IList<int> PreorderTraversal(TreeNode root) {
        
        // In the case where the current node is null return an empty list as a base case
        if (root == null)
        {
            return new List<int>();
        }

        // Add the current node's value to the traversal list
        PreOrderTreeValues.Add(root.val);

        // Perform all Left subtree traversals from the current node
        PreorderTraversal(root.left);

        // After left subtree traversal, traverse all right subtrees from the current node
        PreorderTraversal(root.right);

        // After all traversals have been done return the traversal list
        return PreOrderTreeValues;
    }
}