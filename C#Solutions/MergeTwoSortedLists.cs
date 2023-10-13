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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        // Define the output ListNodes to create the new merged Linked List
        ListNode currentNode = new ListNode();
        ListNode headNode = currentNode;

        // While List 1 and 2 aren't currently at the end of their list, compare values and iterate
        while(list1 != null && list2 != null)
        {
            // Check which list has the lower value and add it to the end of the merged list
            if (list1.val < list2.val)
            {
                // Add the current node of List 1 to the merged list and move its position to the next node
                currentNode.next = list1;
                list1 = list1.next;
            } else
            {
                // Else add the current node of List 2 to the merged list and move its position to the next node
                currentNode.next = list2;
                list2 = list2.next;
            }

            // After calculating which node to add, refer to the stored node in the next value as the current node
            // This next value will be overwritten over the next iteration
            currentNode = currentNode.next;
        }

        // Perform a check to add any final nodes of a list to the merged list
        if (list1 != null) { currentNode.next = list1; }
        if (list2 != null) { currentNode.next = list2; }

        // Return the head node of the merged list that points to the rest of the nodes (skip first list item)
        return headNode.next;
    }
}