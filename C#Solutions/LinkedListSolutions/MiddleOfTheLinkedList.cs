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
    public ListNode MiddleNode(ListNode head) {
        // Initialize a length counter
        int length = 0;
        // Create a temporary list pointer and iterate through the list
        ListNode temp = head;
        while(temp != null)
        {
            // For each node count the length
            length++;
            temp = temp.next;
        }
        // Find the middle index and iterate through the list
        length = length/2;
        while(length>0)
        {
            head = head.next;
            length--;
        }

        // When the middle node is reached return the list
        return head;
    }
}