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
    // Iterative Approach to processing Linked Lists
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // Declare Working Sum List variables
        ListNode sumHead = new ListNode(0);
        ListNode currentNode = sumHead;
        int carry = 0;

        // Iterate through the lists while they still have nodes
        while ( l1 != null || l2 != null || carry != 0)
        {
            // If the lists are not null set the value of digits 
            int digit1 = (l1 != null) ? l1.val : 0;
            int digit2 = (l2 != null) ? l2.val : 0;

            // Calculate the sum of the digits and the carry
            int sum = digit1 + digit2 + carry;
            int value = sum % 10;
            carry = sum/10;

            // Declare the new Sum node and store reference
            currentNode.next = new ListNode(value);
            currentNode = currentNode.next;

            // Iterate the two lists to the next nodes and repeat the process
            l1 = (l1 != null) ? l1.next : null;
            l2 = (l2 != null) ? l2.next : null;

        }
        // Return the first reference to the start of the new Linked List
        return sumHead.next;
    }

    // Recursive Approach that requires modifying the parameters of the function
    public ListNode AddTwoNumbersRecursive(ListNode l1, ListNode l2, int carry = 0) {
        // Declare a base case to end iteration when all lists and carry are finished
        if (l1 == null && l2 == null && carry == 0) { return null; }

        // Determine the values of the each lists' current node
        int digit1 = (l1 != null) ? l1.val : 0;
        int digit2 = (l2 != null) ? l2.val : 0;

        // Calculate the sum of the digits and the carry
        int sum = digit1 + digit2 + carry;
        int value = sum % 10;
        carry = sum/10;

        // Recursively call the function iterating the two lists as long as they don't point to null
        return new ListNode(value, AddTwoNumbersRecursive(l1?.next, l2?.next, carry));
    }
}