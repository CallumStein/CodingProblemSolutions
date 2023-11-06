/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        // Declare a processing List to store previous visited nodes
        //List<ListNode> previousNodes = new List<ListNode>();

        // Declare a Hash Set to store previous visited nodes as it is much better for the application
        HashSet<ListNode> previousNodes = new HashSet<ListNode>();
        
        // Keep iterating through the list until the end is reached
        while (head != null )
        {
            // If the current node is ever found to be contained in the previous nodes list return true
            if (previousNodes.Contains(head)) { return true; }

            // Else add the current node to the list and iterate
            previousNodes.Add(head);
            head = head.next;
        }

        // If the loop is ever broken return false
        return false;
    }
}