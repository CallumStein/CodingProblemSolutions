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
    public ListNode DeleteDuplicates(ListNode head) {
        
        // Check for empty list scenarios
        if (head == null)
        {
            return head;
        }

        // Create a working node for reference
        ListNode sortedList = head;

        // Loop through the Sorted List
        while (sortedList.next != null)
        {            
            // Store reference to the next node in the list
            ListNode nextNode = sortedList.next;

            // Check if the nextNode has the same value as the current node
            if (sortedList.val == nextNode.val)
            {
                // If the current node and next node share the same value skip the next node
                sortedList.next = nextNode.next;
            }
            else
            {
                // Else if not duplicate, iterate as usual
                sortedList = sortedList.next;
            }
        }
        // Return the head of the sorted list
        return head;
    }
}