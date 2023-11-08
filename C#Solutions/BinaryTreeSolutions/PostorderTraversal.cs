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
    // Public attribute List to store Postorder values
    List<int> PostorderValues = new List<int>();

    public IList<int> PostorderTraversal(TreeNode root) {
        
        // Base case to break recursion if the current node is null
        if (root == null) { return new List<int>(); }

        // Traverse all left subtrees from the current node
        PostorderTraversal(root.left);

        // Traverse all possible right subtrees after left subtree traversal
        PostorderTraversal(root.right);

        // Store the value of the current node after all traversals have been performed
        PostorderValues.Add(root.val);
        
        // Return the public List
        return PostorderValues;
    }
}