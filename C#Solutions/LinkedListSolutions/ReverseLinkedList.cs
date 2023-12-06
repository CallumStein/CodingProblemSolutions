/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {

    // Attribute to store reference to the first node of the new list
    private ListNode reverseHead = new ListNode(0);

    // Main problem function
    public ListNode ReverseList(ListNode head) {

        // Define an edge case where the list is either a single node or empty list
        if (head == null || head.next == null ) { return head; }

        // Call the first instance of the recursive function storing reference for the last node
        ListNode lastReverseListNode = RecursiveReverse(head);

        // End the list by setting the next node to null to avoid an endless loop
        lastReverseListNode.next = null;

        // Return the start of the reverse lists head
        return reverseHead;

    }

    // Auxiliary recursive function
    public ListNode RecursiveReverse(ListNode node) {
        
        // If the next node is null
        if (node.next == null)
        {
            // Store reference to the new head as the last node of the list
            reverseHead = node;
            return node;
        }

        // Otherwise recursively call the function for the next node
        ListNode nextNode = RecursiveReverse(node.next);

        // When all nodes are found, going through the stack reversing the order
        nextNode.next = node;
        return node;
    }
}