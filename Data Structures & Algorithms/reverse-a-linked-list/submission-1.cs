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
        if (head is null) return head;
        ListNode next = head.next;
        head.next = null;
        while (next is not null) {
            ListNode tmp = next.next;
            next.next = head;
            head = next;
            next = tmp;
        }   
        return head; 
    }
}
