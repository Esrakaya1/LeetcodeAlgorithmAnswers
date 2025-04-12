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
        ListNode ans = new ListNode(0), curr = ans;
        ans.next = head;
        while(curr.next != null) {
            if(curr.next.val == val) curr.next = curr.next.next;
            else curr = curr.next;
        }
        return ans.next;
    }
}

// Time Complexity: O(n) where n is the number of nodes in the linked list. We traverse the list once, checking each node's value and potentially removing it.
// Space Complexity: O(1) since we are not using any additional data structures that grow with the input size. We are only using a few pointers like ans and curr to keep track of the current node and the head of the list.