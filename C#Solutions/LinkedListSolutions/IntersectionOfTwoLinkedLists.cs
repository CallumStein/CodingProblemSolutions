/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        // Initialize a processing List to store reference to nodes
        List<ListNode> listA = new List<ListNode>();

        // Iterate through all of List A storing reference to each node
        while(headA != null) 
        { 
            listA.Add(headA);
            headA = headA.next;
        }
        // Iterate through list B comparing each node to the List that stores A
        while(headB != null)
        {
            if (listA.Contains(headB))
            {
                return headB;
            }

            headB = headB.next;
        } 

        // In the case of no matching nodes return null
        return null;
    }
}