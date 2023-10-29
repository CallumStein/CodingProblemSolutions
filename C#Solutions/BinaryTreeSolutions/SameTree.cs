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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // Declare necessary processing stacks
        var pStack = new Stack<TreeNode>();
        var qStack = new Stack<TreeNode>();

        // Declare processing nodes for current roots for both p and q
        TreeNode pCurrentRoot = p;
        TreeNode qCurrentRoot = q;

        // Iterate through the two Binary Trees until they run out of nodes
        while(pCurrentRoot != null || qCurrentRoot != null || pStack.Count != 0 && qStack.Count != 0)
        {
            // For testing purposes, reads the current node values ignoring null exceptions
            Console.WriteLine("pStack: " + pCurrentRoot?.val + " qStack: " + qCurrentRoot?.val);

            // Compare the values of p and q as traversal occurs ignoring null exceptions, both trees should be equal in traversal
            if (pCurrentRoot?.val != qCurrentRoot?.val)
            {
                return false;
            }

            // Perform a left traversal of the binary trees
            if (pCurrentRoot != null || qCurrentRoot != null)
            {
                // Push the current node to their respective stacks
                pStack.Push(pCurrentRoot);
                qStack.Push(qCurrentRoot);
                // Move both trees to the next left node
                pCurrentRoot = pCurrentRoot.left;
                qCurrentRoot = qCurrentRoot.left;
                // Return to start of while loop
                continue;
            }

            // Read the Node data after left traversal in the order they were discovered
            pCurrentRoot = pStack.Pop();
            qCurrentRoot = qStack.Pop();

            // Perform a right traversal of the most recent node
            pCurrentRoot = pCurrentRoot.right;
            qCurrentRoot = qCurrentRoot.right;
        }

        // Return True if no condition is found where the trees don't match
        return true;
    }
}