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

    // Declare a public attribute to store inorder values
    IList<int> resultList = new List<int>();

    public IList<int> InorderTraversal(TreeNode root) {
        
        // If the end of a branch is not reached, Continue the sequence
        if (root != null)
        {
            // Traverse all possible left branches from the current node
            InorderTraversal(root.left);
            // When a break finally occurs, add the value of that node to the list
            resultList.Add(root.val);
            // Then from that node, traverse the right branch and repeat the process
            InorderTraversal(root.right);
        }

        // Once all possible traversal have occurred, return the processed List
        return resultList;
    }
}