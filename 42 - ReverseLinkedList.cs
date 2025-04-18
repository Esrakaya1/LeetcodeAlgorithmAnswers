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
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;

        while(curr != null)
        {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}

// Iterative approach to reverse a singly linked list

// Time Complexity: O(n) where n is the number of nodes in the linked list. We traverse each node once.
// Space Complexity: O(1) since we are using only a constant amount of extra space. curr, prev, and temp are all pointers that take up constant space.