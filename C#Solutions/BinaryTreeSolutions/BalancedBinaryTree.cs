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
    public bool IsBalanced(TreeNode root) {
        
        // If the Binary tree reaches a point where both sub trees end they must be equal
        if (root == null)
        {
            return true;
        }

        // Call the DFS GetHeight() function for each of the current nodes subtrees
        int leftHeight = GetHeight(root.left);
        int rightHeight = GetHeight(root.right);

        // If any of the subtree's height are more than 1 depth greater than the other
        if(leftHeight > rightHeight + 1 || rightHeight > leftHeight + 1)
        {
            // return false
            return false;
        }
        // recursively call the function comparing each subtree from the current node
        return IsBalanced(root.left) && IsBalanced(root.right);
    }

    // Auxiliary Function to perform a Depth-First search to calculate height
    public int GetHeight(TreeNode root) {

        // Base case for recursive function for when end of subtree is reached
        if (root == null)
        {
            return 0;
        }

        // Recursively call the function for each subtree return only the height of the larger subtree
        return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
    }
}