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
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        // check if head is null or not 
        if (head != null)
        {
            // create new node
            ListNode current = head;

            //loop
            while (current.next != null)
            {
                if (current.val == current.next.val)
                { // dublicate
                    ListNode temp = current.next;
                    current.next = temp.next;
                }
                else
                {
                    current = current.next; // there is no dublicate
                }
            }
        }
        return head;
    }
}

// time complexity => O(n): The time complexity of this algorithm is O(N), where N is the number of nodes in the linked list. This is because it processes each node in the list once, and the number of iterations is proportional to the number of nodes.

// space complexity => O(1): Only current and temp variables are used,  no extra space for arrays or recursion stacks.