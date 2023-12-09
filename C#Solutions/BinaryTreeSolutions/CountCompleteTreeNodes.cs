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
    // Attribute to store count
    private int count = 0;

    // Original function to determine the count
    public int CountNodes(TreeNode root) {
        if (root == null)
        {
            return 0;
        }

        // Call the recursive inorder search of the binary tree that counts each node thats found
        SearchBinaryTree(root);

        // Return the count
        return count;
    }

    // Auxilliary function to recursively iterate through the binary tree
    public void SearchBinaryTree(TreeNode node) {

        // If the current exists in the tree
        if (node != null)
        {
            // recursively search the left branches of each node
            SearchBinaryTree(node.left);

            // After iterating through all left subtrees, increase the count for each node found by 1
            count += 1;

            // recursively search the right branches of each node repeating the process and increasing the count by 1 for each node found
            SearchBinaryTree(node.right);
        }
    }
}