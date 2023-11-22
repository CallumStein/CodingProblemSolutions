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
    public ListNode RemoveElements(ListNode head, int val) {

        // Declare Edge case where the first element or subsequent elements need to be removed
        while (head != null && head.val == val) { head = head.next; }

        // Check if the current list is empty and return null if it is
        if (head == null) { return null; }

        // Declare a storage ListNode to store reference to the next nodes
        ListNode currentNode = head;
        ListNode newHeadNode = currentNode;

        // Iterate through the linked list checking if the NEXT node is present
        while(currentNode.next != null)
        {
            // Check if the value of the next node to see if it needs to be removed
            if(currentNode.next.val == val)
            {
                // Skip over the next node if it has the val to be removed
                currentNode.next = currentNode.next.next;
            }
            else
            {
                // Iterate the list
                currentNode = currentNode.next;
            }
        }

        // Return the reference to the new list
        return newHeadNode;
    }
}