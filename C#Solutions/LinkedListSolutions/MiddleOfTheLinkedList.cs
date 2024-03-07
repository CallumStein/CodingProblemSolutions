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
        // Create a new head pointer for the linked list
        ListNode temp = head;
        // Iterate through the list checking that the current and next node are valid
        while(temp != null && temp.next != null)
        {
            // Traverse the list iterating to the end of the temp list at twice the speed
            head = head.next;
            temp = temp.next.next;
        }
        // When the end of the temp list is reached, the main list will be halfway
        return head;
    }
}